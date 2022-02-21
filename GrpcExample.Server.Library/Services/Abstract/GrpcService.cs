using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcExample.Server.Library.Model;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NotificationGrpcService;

namespace GrpcExample.Server.Library.Abstract
{
    public sealed class GrpcService<TRequest,TResponse>
        where TRequest : class
    {
        private readonly ServerGrpcSubscribersBase<TResponse> _serverGrpcSubscribersBase;
        private readonly MessageProcessorBase<TRequest, TResponse> _messageProcessor;
        private IHostApplicationLifetime _lifetime;

        private ILogger _logger { get; set; }

        public GrpcService(
            ILoggerFactory loggerFactory, 
            ServerGrpcSubscribersBase<TResponse> serverGrpcSubscribersBase, 
            MessageProcessorBase<TRequest, TResponse> messageProcessor,
            IHostApplicationLifetime lifetime)
        {
            _serverGrpcSubscribersBase = serverGrpcSubscribersBase;
            _messageProcessor = messageProcessor;
            _logger = loggerFactory.CreateLogger<GrpcService<TRequest, TResponse>>();
            _lifetime = lifetime;
        }

        public async Task CreateDuplexStreaming(
            IAsyncStreamReader<TRequest> requestStream, 
            IServerStreamWriter<TResponse> responseStream, 
            ServerCallContext context)
        {
            var httpContext = context.GetHttpContext();
            
            var cancellationSource = CancellationTokenSource.CreateLinkedTokenSource(
                context.CancellationToken, _lifetime.ApplicationStopping, _lifetime.ApplicationStopped);
            
            _logger.LogInformation($"Connection id: {httpContext.Connection.Id}");

            if (!await requestStream.MoveNext(cancellationSource.Token))
                return;

            var clientId = _messageProcessor.GetClientId(requestStream.Current);
            _logger.LogInformation($"{clientId} connected");
            var subscriber = new SubscribersModel<TResponse>
            {
                Subscriber = responseStream,
                Id = $"{clientId}"
            };

            _serverGrpcSubscribersBase.AddSubscriber(subscriber);

            do
            {
                if (requestStream.Current == null)
                    continue;

                var resultMessage = _messageProcessor.Process(requestStream.Current);
                
                if (resultMessage == null)
                    continue;
                
                var response = resultMessage as RegisterResponse;
                if (response.Type == MessageType.Unsubscribe)
                {
                    _serverGrpcSubscribersBase.RemoveSubscriber(subscriber);
                    break;
                }

                await _serverGrpcSubscribersBase.BroadcastMessageAsync(resultMessage);
            } while (await requestStream.MoveNext(cancellationSource.Token));

            _serverGrpcSubscribersBase.RemoveSubscriber(subscriber);
            _logger.LogInformation($"{clientId} disconnected");
        }

        public void Dispose()
        {
            _logger.LogInformation("Cleaning up");
        }
    }
}