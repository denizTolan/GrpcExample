using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcExample.Client.Library.Model.Events;
using Channel = Grpc.Core.Channel;

namespace GrpcExample.Client.Library.GrpcService
{
    public abstract class GrpcClientBase<TRequest, TResponse> : IDisposable
    {
        protected readonly Channel _channel;
        protected readonly AsyncDuplexStreamingCall<TRequest, TResponse> _duplexClient;
        
        public event EventHandler<ProcessEventArgs> OnCallStarted;
        public event EventHandler<ProcessEventArgs> OnShuttingDown;
        public event EventHandler OnServerCreatedMessage;
            
        public GrpcClientBase(Channel channel)
        {
            this._channel = channel;
            this._duplexClient = CreateDuplexClient(channel);
        }
        
        public abstract AsyncDuplexStreamingCall<TRequest, TResponse> CreateDuplexClient(Channel channel);

        public abstract TRequest CreateMessage(object ob);
        
        public abstract TRequest UnSubscribeMessage();

        public abstract string MessagePayload { get; }

        public async Task StartCall()
        {
            if (OnCallStarted != null)
            {
                OnCallStarted.Invoke("OnCallStarted",new ProcessEventArgs()
                {
                    CompletionTime = DateTime.Now,
                    IsSuccessful = true
                });
            }

            //Register
            await this._duplexClient.RequestStream.WriteAsync(CreateMessage("Hello"));
        }
        
        public async Task SendUnsubscribeMessage()
        {
            await this._duplexClient.RequestStream.WriteAsync(UnSubscribeMessage());
        }
        
        public async Task<Status> GetConnectionStatus()
        {
            await this._channel.WaitForStateChangedAsync(ChannelState.Ready,null);
            return await Task.FromResult<Status>(this._duplexClient.GetStatus());
        }
        
        public Status GetConnectionStatusAsync()
        {
            return this._duplexClient.GetStatus();
        }

        public virtual Task ListenServer()
        {
            var responseTask = Task.Run(async () =>
            {
                while (await this._duplexClient.ResponseStream.MoveNext(CancellationToken.None))
                {
                    
                    Console.WriteLine($"{this._duplexClient.ResponseStream.Current}");
                }
            });

            return responseTask;
        }

        public virtual async Task ListenServerAsync(CancellationToken cancellationToken)
        {
            try
            {
                while (await this._duplexClient.ResponseStream.MoveNext(cancellationToken))
                {
                    if (this.OnServerCreatedMessage != null)
                        this.OnServerCreatedMessage.Invoke(this._duplexClient.ResponseStream.Current,null);
                    
                    Console.WriteLine($"{this._duplexClient.ResponseStream.Current}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ShutDownClient()
        {
            this._duplexClient.RequestStream.CompleteAsync();
            this._channel.ShutdownAsync();
            
            if (this.OnShuttingDown != null)
            {
                this.OnShuttingDown.Invoke("OnShuttingDown",new ProcessEventArgs()
                {
                    CompletionTime = DateTime.Now,
                    IsSuccessful = true
                });
            }
        }

        public void Dispose()
        {
            this._duplexClient.Dispose();
        }
    }
}