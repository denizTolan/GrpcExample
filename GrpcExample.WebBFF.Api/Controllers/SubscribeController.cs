using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcExample.WebBFF.Api.Model;
using GrpcExample.WebBFF.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GrpcExample.WebBFF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscribeController : ControllerBase
    {
        private readonly ILogger<SubscribeController> _logger;
        private readonly ISubscriberService _subscriberService;

        public SubscribeController(ILogger<SubscribeController> logger,ISubscriberService subscriberService)
        {
            _logger = logger;
            this._subscriberService = subscriberService;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(Subscriber subscriber)
        {
            this._subscriberService.RegisterSubscriber(subscriber);
            
            this._logger.LogInformation($"Client Id : {subscriber.ClientId} , Client Name : {subscriber.ClientName} was registered.");

            return Ok();
        }
        
        [HttpPut]
        [Route("unregister")]
        public IActionResult UnRegister(string clientId)
        {
            this._subscriberService.RemoveSubscriber(clientId);
            
            this._logger.LogInformation($"Client Id : {clientId} was removed.");

            return Ok();
        }
    }
}