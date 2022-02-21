using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrpcExample.Server.Library;
using NotificationGrpcService;

namespace GrpcExample.Server.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriberController : ControllerBase
    {
        private readonly ServerGrpcSubscribers _grpcSubscribers;

        public SubscriberController(ServerGrpcSubscribers grpcSubscribers)
        {
            this._grpcSubscribers = grpcSubscribers;
        }
        
        [HttpGet]
        [Route("GetSubscriberList")]
        public JsonResult Index()
        {
            var subscriberList = this._grpcSubscribers.GetSubscriberList();
            return new JsonResult(subscriberList);
        }

        [HttpPost]
        [Route("BrodcastMessage")]
        public async Task<JsonResult> BrodcastMessage(string message)
        {
            await _grpcSubscribers.BroadcastMessageAsync(new RegisterResponse()
            {
                Payload = message,
                Status = MessageStatus.Created,
                MessageId = Guid.NewGuid().ToString(),
                Time = DateTime.Now.Ticks
            });
            
            return new JsonResult(Ok());
        }
    }
}
