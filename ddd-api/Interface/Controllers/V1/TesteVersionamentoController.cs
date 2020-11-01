using Interface.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace Interface.Controllers.V1
{
    [Obsolete()]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class TesteVersionamentoController : BaseController
    {
        public TesteVersionamentoController(INotificador notificador) : base(notificador)
        {
        }

        [HttpGet]
        public ActionResult ReturnString()
        {
            return CustomResponse("Eu sou a V1") ;
        }
    }
}
