using System;
using Grpc.Core;
using NotificationGrpcService;

namespace GrpcExample.Client.Library.GrpcService
{
    public class GrpcClient : GrpcClientBase<RegisterRequest,RegisterResponse>
    {
        public string ClientId { get; }

        public GrpcClient(Channel channel)
            : base(channel)
        {
            this.ClientId = $"{Guid.NewGuid()}";
        }
        
        public override AsyncDuplexStreamingCall<RegisterRequest, RegisterResponse> CreateDuplexClient(Channel channel)
        {
            return new Notification.NotificationClient(channel).Register();
        }

        public override RegisterRequest CreateMessage(object ob)
        {
            var payload = $"{ob}";

            return new RegisterRequest
            {
                ClientId = ClientId,
                MessageId = $"{Guid.NewGuid()}",
                Type = MessageType.Ordinary,
                Time = DateTime.UtcNow.Ticks,
                Response = ResponseType.Required,
                Payload = payload
            };
        }

        public override RegisterRequest UnSubscribeMessage()
        {
            return new RegisterRequest
            {
                ClientId = ClientId,
                MessageId = $"{Guid.NewGuid()}",
                Type = MessageType.Unsubscribe,
                Time = DateTime.UtcNow.Ticks,
                Response = ResponseType.Required,
                Payload = $"{ClientId} UnSubscribe"
            };
        }

        public override string MessagePayload
        {
            get => Console.ReadLine();
        }
    }
}