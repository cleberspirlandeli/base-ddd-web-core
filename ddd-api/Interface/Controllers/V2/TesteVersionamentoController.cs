using Interface.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace Interface.Controllers.V2
{
    [Obsolete()]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class TesteVersionamentoController : BaseController
    {
        public TesteVersionamentoController(INotificador notificador) : base(notificador)
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
            return CustomResponse("Eu sou a V2");
        }
    }
}
