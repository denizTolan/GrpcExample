using System;
using System.Threading.Tasks;
using GrpcExample.WebBFF.Api.Model;

namespace GrpcExample.WebBFF.Api.Services.Interface
{
    public interface ISubscriberService
    {
        void RegisterSubscriber(Subscriber subscriberModel);
        void RemoveSubscriber(string clientId);
        Task NotifySubscribers(string message);
        Subscriber GetSubscriber(string clientId);
        Task NotifySubscriber(string clientId,string message);
    }
}