using Domain.Commands;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class ContactController : BaseController
    {
        [HttpPost]
        [Route("api/v1/contact")]
        public HttpResponseMessage RegisterContact([FromBody]RegisterContactCommand command)
        {
            RegisterContactService service = new RegisterContactService(command);
            service.Run();

            return ReturnResponse(service, new { message = "Usuário cadastrado com sucesso" }, null);
        }
    }
}
