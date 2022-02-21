using System;

namespace GrpcExample.Test.SF.Models
{
    public class Subscriber
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientServerAdress { get; set; }
        public string CallbackEndpoint { get; set; }
        public DateTime SubscribedTime { get; set; }
    }
}