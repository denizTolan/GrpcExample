using Grpc.Core;

namespace GrpcExample.Server.BusinessLayer.Model
{
    public class SubscribersModel<TResponse>
    {
        public IServerStreamWriter<TResponse> Subscriber { get; set; }

        public string Id { get; set; }
    }
}