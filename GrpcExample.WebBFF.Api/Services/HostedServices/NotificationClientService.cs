using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcExample.Client.Library.GrpcService;
using GrpcExample.Client.Library.Model.Events;
using GrpcExample.WebBFF.Api.Services.Interface;
using Microsoft.Extensions.Hosting;

namespace GrpcExample.WebBFF.Api.Services.HostedServices
{
    public class NotificationClientService : BackgroundService
    {
        private readonly SslCredentials _channelCredentials;
        private readonly Channel _channel;
        private readonly ISubscriberService _subscriberService;
        private readonly IHostApplicationLifetime _lifetime;
        
        private const int PORT = 19020;
        private Guid ClientId { get; set; } = Guid.NewGuid();

        public NotificationClientService(ISubscriberService subscriberService,IHostApplicationLifetime lifetime)
        {
            _channelCredentials = new SslCredentials(File.ReadAllText(@"certificate.crt"));
            _channel = new Channel($"localhost:{PORT}",_channelCredentials);
            _subscriberService = subscriberService;
            _lifetime = lifetime;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var taskCompletionSource = new TaskCompletionSource();
            stoppingToken.Register(() => taskCompletionSource.SetResult());
           
            using (var client = new GrpcClient(_channel))
            {
                _lifetime.ApplicationStopping.Register(async () =>
                {
                    await client.SendUnsubscribeMessage();
                    client.ShutDownClient();
                });
                client.OnCallStarted += ClientOnCallStarted;
                client.OnShuttingDown += ClientOnShuttingDown;
                client.OnServerCreatedMessage += ClientOnServerCreatedMessage;
                await client.StartCall();

                var listeningTask = client.ListenServerAsync(stoppingToken);
                var statusTask = client.GetConnectionStatus();
            
                //Task.WaitAll(new Task[]{listeningTask,statusTask},stoppingToken);
                Task.WaitAll(new Task[]{listeningTask},stoppingToken);

                client.ShutDownClient();
            }
        }

        private void ClientOnServerCreatedMessage(object? sender, EventArgs e)
        {
            this._subscriberService.NotifySubscribers(sender.ToString());
        }

        private void ClientOnShuttingDown(object? sender, ProcessEventArgs e)
        {
            
        }

        private void ClientOnCallStarted(object? sender, ProcessEventArgs e)
        {
            
        }
    }
}