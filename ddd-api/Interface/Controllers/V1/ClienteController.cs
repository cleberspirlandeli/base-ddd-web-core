﻿using Common;
using Common.DTO.FuncionalidadeCliente;
using Interface.Controllers.Common;
using KissLog;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Interface.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ClienteController : BaseController
    {
        private readonly ClienteApplicationService _appService;
        public ClienteController(INotificador notificador,
            ILogger logger,
            ClienteApplicationService appService) : base(notificador, logger)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAll()
        {
            var result = await _appService.GetAll();
            return CustomResponse(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAllWithError(int id)
        {
            var result = await _appService.GetAllWithError();
            return CustomResponse(result);
        }

    }
}
