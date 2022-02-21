using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GrpcExample.WebBFF.Api.Model;
using GrpcExample.WebBFF.Api.Services.Interface;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace GrpcExample.WebBFF.Api.Services
{

    public class SubscriberService : ISubscriberService
    {
        private readonly ConcurrentDictionary<string, Subscriber> _subscriberDictionary;
        private readonly HttpClient _httpClient;
        private readonly MemoryService _memoryService;
        
        public SubscriberService(HttpClient httpClient,MemoryService memoryService)
        {
            this._subscriberDictionary = new ConcurrentDictionary<string, Subscriber>();
            this._httpClient = httpClient;
            this._memoryService = memoryService;

            var lastSubscriberList = memoryService.GetAllSubscribers();
            memoryService.AddSubscriberList(lastSubscriberList);
        }

        public void RegisterSubscriber(Subscriber subscriberModel)
        {
            if (this._subscriberDictionary.ContainsKey(subscriberModel.ClientId))
            {
                return;
            }
            
            this._subscriberDictionary.TryAdd(subscriberModel.ClientId,subscriberModel);
            this._memoryService.AddSubscriber(subscriberModel);
        }

        public void RemoveSubscriber(string clientId)
        {
            if (this._subscriberDictionary.ContainsKey(clientId))
            {
                Subscriber subscriber = null;
                this._subscriberDictionary.TryRemove(clientId,out subscriber);
            }
        }

        public async Task NotifySubscribers(string message)
        {
            foreach (var subscriber in _subscriberDictionary.Values)
            {
                await this.NotifySubscriber(subscriber,message);
            }
        }

        public Subscriber GetSubscriber(string clientId)
        {
            if (!_subscriberDictionary.ContainsKey(clientId))
                throw new Exception("Registered user not found.");

            Subscriber foundedSubscriber;
            this._subscriberDictionary.TryGetValue(clientId,out foundedSubscriber);

            return foundedSubscriber;
        }

        public async Task NotifySubscriber(string clientId,string message)
        {
            var foundedSubscriber = this.GetSubscriber(clientId);
            
            await NotifySubscriber(foundedSubscriber,message);
        }
        
        private async Task NotifySubscriber(Subscriber subscriberModel,string message)
        {
            var body = new CallbackModel()
            {
                CallbackId = Guid.NewGuid().ToString(),
                Message = message
            };
            
            var result = await this._httpClient.PostAsJsonAsync(
                new Uri($"{subscriberModel.ClientServerAdress}{subscriberModel.CallbackEndpoint}"),
                JsonConvert.SerializeObject(body)
                );
        }
    }
}