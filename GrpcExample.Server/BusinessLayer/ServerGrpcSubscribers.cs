using GrpcExample.Server.BusinessLayer.Abstract;
using GrpcExample.Server.BusinessLayer.Model;
using Microsoft.Extensions.Logging;
using NotificationGrpcService;

namespace GrpcExample.Server.BusinessLayer
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