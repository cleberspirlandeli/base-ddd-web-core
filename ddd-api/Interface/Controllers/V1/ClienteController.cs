using Common.DTO.Cadastro;
using Interface.Controllers.Common;
using Interface.Extensions;
using KissLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Modules.Cadastro;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Interface.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    [ApiController]
    public class ClienteController : BaseController
    {
        private readonly ClienteApplicationService _appService;
        public ClienteController(INotificador notificador,
            ClienteApplicationService appService) : base(notificador)
        {
            _appService = appService;
        }

        /// <summary>
        /// Obter todos os Clientes
        /// </summary>
        /// <returns>Lista de ClienteDto</returns>
        [HttpGet]
        //[ClaimsAuthorize("Cliente", "Listar")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAll()
        {
            var result = await _appService.GetAll();
            return CustomResponse(result);
        }

        /// <summary>
        /// Obter Cliente por identificador
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns>Um ClienteDto</returns>
        [HttpGet("{id:int}")]
        [ClaimsAuthorize("Cliente", "ListarId")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _appService.GetById(id);
            return CustomResponse(result);
        }

        /// <summary>
        /// Inserir um novo Cliente
        /// </summary>
        /// <param name="Nome">Nome</param>
        /// <param name="Cpf">Cpf</param>
        /// <param name="DataNascimento"></param>
        /// <param name="Ativo"></param>
        /// <returns>ClienteDto</returns>
        [HttpPost]
        [ClaimsAuthorize("Cliente", "Adicionar")]
        public async Task<IActionResult> Insert(ClienteDto dto)
        {
            await _appService.Insert(dto);
            return CustomResponse();
        }

        /// <summary>
        /// Alterar um Cliente já existente
        /// </summary>
        /// <param name="Nome">Nome</param>
        /// <param name="Cpf">Cpf</param>
        /// <param name="DataNascimento"></param>
        /// <param name="Ativo"></param>
        /// <returns>200</returns>
        [HttpPut("{id:int}")]
        [ClaimsAuthorize("Cliente", "Editar")]
        public async Task<IActionResult> Update(int id, ClienteDto dto)
        {
            await _appService.Update(id, dto);
            return CustomResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        [ClaimsAuthorize("Cliente", "Deletar")]
        public async Task<IActionResult> Delete(int id)
        {
            await _appService.Delete(id);
            return CustomResponse();
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAllWithError(int id)
        //{
        //    var result = await _appService.GetAllWithError();
        //    return CustomResponse(result);
        //}



    }
}
