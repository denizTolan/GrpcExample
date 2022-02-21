using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GrpcExample.Test.SF.Models;
using Newtonsoft.Json;
using RestSharp;

namespace GrpcExample.Test.SF.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //http://localhost:44360
            ViewBag.Title = "Home Page";

            var httpClient = new HttpClient();

            var body = new Subscriber()
            {
                ClientName = Environment.MachineName,
                CallbackEndpoint = @"api/notification/notify",
                ClientId = Guid.NewGuid().ToString(),
                ClientServerAdress = $@"{HttpContext.Request.Url.ToString()}",
                SubscribedTime = DateTime.Now
            };
            
            var response = await httpClient.PostAsync($"https://localhost:44360/api/Subscribe/register", new StringContent(JsonConvert.SerializeObject(body), 
                Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            
            return View();
        }
    }
}
