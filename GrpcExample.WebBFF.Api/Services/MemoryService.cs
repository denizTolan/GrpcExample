using System.Collections.Generic;
using System.Threading;
using GrpcExample.WebBFF.Api.Data;
using GrpcExample.WebBFF.Api.Model;
using Microsoft.Extensions.Caching.Memory;

namespace GrpcExample.WebBFF.Api.Services
{
    public class MemoryService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly SubscriberRepository _repository;
        
        public MemoryService(IMemoryCache memoryCache,SubscriberRepository repository)
        {
            this._memoryCache = memoryCache;
            this._repository = repository;
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            List<Subscriber> subscribers = new List<Subscriber>();
            this._memoryCache.TryGetValue("subscriber",out subscribers);
            
            subscribers.Add(subscriber);
            this._memoryCache.Set("subscriber", subscribers);
            
            this._repository.InsertSubscriber(subscriber);
        }
        
        public void AddSubscriberList(List<Subscriber> subscriberList)
        {
            this._memoryCache.Set("subscriber", subscriberList);
        }

        public List<Subscriber> GetAllSubscribers()
        {
            List<Subscriber> subscribers;
            this._memoryCache.TryGetValue("subscriber",out subscribers);

            if (subscribers != null)
                return subscribers;
            
            return this._repository.GetSubscriberList();
        }
    }
}