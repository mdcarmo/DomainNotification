using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class BaseController : ApiController
    {
        public HttpResponseMessage ReturnResponse(ServerCommand service, object success, object error)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            if (service.HasNotifications())
                response = Request.CreateResponse(HttpStatusCode.BadRequest, new { success = false, data = error, 
                    errors = service.GetNotifications() });
            else
                response = Request.CreateResponse(HttpStatusCode.OK,new { success = true, data = success });

            return response;
        }
    }
}
