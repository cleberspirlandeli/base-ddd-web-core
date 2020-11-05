using Interface.Controllers.Common;
using KissLog;
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
        public TesteVersionamentoController(INotificador notificador, ILogger logger) : base(notificador, logger)
        {
        }


        /// <summary>
        /// Adiciona um Usuário na base de dados
        /// </summary>
        /// <remarks>
        /// TipoUsuario (Possíveis entradas) 
        ///
        ///     1 - Pessoa Física
        ///     2 - Pessoa Jurídica
        /// </remarks> 
        [HttpGet]
        public ActionResult ReturnString()
        {
            _loggerBase.Debug("Hello world from .NET Core 3.x!");
            return CustomResponse("Eu sou a V1") ;
        }
    }
}
