using Interface.Controllers.Common;
using KissLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace Interface.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class TesteVersionamentoController : BaseController
    {
        public TesteVersionamentoController(INotificador notificador, ILogger logger) : base(notificador, logger)
        {
        }

        /// <summary>
        /// Teste Documentação Swagger.
        /// </summary>
        /// <param name="id">Id is id</param>  
        [HttpGet]
        public ActionResult ReturnString()
        {
            throw new Exception("Teste Error");

            return CustomResponse("Eu sou a V2");
        }
    }
}
