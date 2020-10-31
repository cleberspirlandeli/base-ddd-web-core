using Common.DTO.FuncionalidadeCliente;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteApplicationService _appService;
        public ClienteController(ClienteApplicationService appService)
        {
            _appService = appService;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAll()
        {
            var result = await _appService.GetAll();
            return Ok(result);
        }

    }
}
