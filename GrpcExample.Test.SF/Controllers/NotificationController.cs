using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using GrpcExample.Test.SF.Models;

namespace GrpcExample.Test.SF.Controllers
{
    public class NotificationController : ApiController
    {
        // Post
        public string Notify([FromBody] CallbackModel callbackModel)
        {
            //http://localhost:44360
            
            return "test";
        }
    }
}