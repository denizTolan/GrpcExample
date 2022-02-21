using GrpcExample.Server.Library.Abstract;
using GrpcExample.Server.Library.Model;
using Microsoft.Extensions.Logging;
using NotificationGrpcService;

namespace GrpcExample.Server.Library
{
    public class ServerGrpcSubscribers : ServerGrpcSubscribersBase<RegisterResponse>
    {
        public ServerGrpcSubscribers(ILoggerFactory loggerFactory) 
            : base(loggerFactory)
        {
        }

        public override bool Filter(SubscribersModel<RegisterResponse> subscriber, RegisterResponse message) => true;
    }
}