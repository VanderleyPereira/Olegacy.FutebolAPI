using Microsoft.AspNetCore.Mvc;
using Olegacy.FutebolAPI.Services;

namespace Olegacy.FutebolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrasileiraoController : ControllerBase
    {
        private readonly IBrasileiraoService _service;

        public BrasileiraoController(IBrasileiraoService service)
        {
            _service = service;
        }

        [HttpGet("tabela")]
        public async Task<IActionResult> GetTabela()
        {
            var tabela = await _service.GetTabelaAsync();
            return Ok(tabela);
        }

        [HttpGet("rodadas")]
        public async Task<IActionResult> GetRodadas()
        {
            var rodadas = await _service.GetRodadasAsync();
            return Ok(rodadas);
        }

        [HttpGet("rodada-atual")]
        public async Task<IActionResult> GetRodadaAtual()
        {
            var rodada = await _service.GetRodadaAtualAsync();
            return Ok(rodada);
        }
    }
}