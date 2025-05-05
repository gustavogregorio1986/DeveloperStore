using AutoMapper;
using DeveloperStore.Data.DTO;
using DeveloperStore.Dominio.Dominio;
using DeveloperStore.Service.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class vendaController : ControllerBase
    {
        private readonly IVendaService _vendaService;
        private readonly IMapper _mapper;

        public vendaController(IVendaService vendaService, IMapper mapper)
        {
            _mapper = mapper;
            _vendaService = vendaService;
        }

        [HttpPost("Cadastrar", Name = "Cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody] VendaDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var venda = _mapper.Map<Venda>(dto);

            await _vendaService.AdicionarVenda(venda);

            return Ok(new { sucesso = true, id = venda.Id });
        }

        [HttpGet("ListarVendas", Name = "ListarVendas")]
        public async Task<IActionResult> ListarVendas()
        {
            var vendas = await _vendaService.ListarVendas();

            var vendasDto = _mapper.Map<List<VendaDTO>>(vendas);

            return Ok(vendasDto);
        }

        [HttpGet("ListarNaocancelados", Name = "ListarNaocancelados")]
        public async Task<IActionResult> ListarNaocancelados()
        {
            var vendas = await _vendaService.ListarNaocancelados(naocancelar: 0);
            var vendasDto = _mapper.Map<List<VendaDTO>>(vendas);
            return Ok(vendasDto);
        }

        [HttpGet("ListarCancelados", Name = "ListarCancelados")]
        public async Task<IActionResult> ListarCancelados()
        {
            var vendas = await _vendaService.ListarCancelados(cancelar: 1);
            var vendasDto = _mapper.Map<List<VendaDTO>>(vendas);
            return Ok(vendasDto);
        }

        [HttpGet("ObterPorId/{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var venda = await _vendaService.ObterPorIdAsync(id);

            if (venda == null)
                return NotFound(new { mensagem = "Venda não encontrada" });

            var vendaDto = _mapper.Map<VendaDTO>(venda);

            return Ok(vendaDto);
        }

        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> Editar(Guid id, [FromBody] VendaDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vendaExistente = await _vendaService.ObterPorIdAsync(id);
            if (vendaExistente == null)
                return NotFound("Venda não encontrada");

            _mapper.Map(dto, vendaExistente);
            await _vendaService.AtualizarAsync(vendaExistente);

            return Ok(new { sucesso = true });
        }

        [HttpDelete("Deletar/{id}")]
        public async Task<IActionResult> Deletar(Guid id)
        {
            var sucesso = await _vendaService.DeletarVendaAsync(id);
            if (!sucesso)
                return NotFound("Venda não encontrada");

            return Ok(new { sucesso = true });
        }


    }
}
