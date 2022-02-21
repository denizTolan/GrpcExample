using System;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcExample.Server.Abstract;
using GrpcExample.Server.BusinessLayer;
using Microsoft.Extensions.Logging;
using NotificationGrpcService;

namespace GrpcExample.Server
{
    public class NotificationService : Notification.NotificationBase , IDisposable
    {
        private readonly GrpcService<RegisterRequest, RegisterResponse> _grpcService;
        
        public NotificationService(ILoggerFactory loggerFactory, ServerGrpcSubscribers serverGrpcSubscribers, MessageProcessor messageProcessor)
        {
            this._grpcService = new GrpcService<RegisterRequest, RegisterResponse>(loggerFactory,serverGrpcSubscribers,messageProcessor);
        }

        public override async Task Register(IAsyncStreamReader<RegisterRequest> requestStream, 
            IServerStreamWriter<RegisterResponse> responseStream, ServerCallContext context)
        {
             await  this._grpcService.CreateDuplexStreaming(requestStream,responseStream,context);
        }

        public void Dispose()
        {
            this._grpcService.Dispose();
        }
    }
}