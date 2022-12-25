using Demo.Refit.Pedidos.Servicos.Interfaces;
using Demo.Refit.Pedidos.Servicos.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Refit.Pedidos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IServicoPagamento servicoPagamento;

    public PedidosController(IServicoPagamento servicoPagamento)
    {
        this.servicoPagamento = servicoPagamento;
    }

    [HttpGet("{id}/pagamentos/{idPagamento}", Name = nameof(ObterPagamento))]
    public async Task<IActionResult> ObterPagamento(int id, int idPagamento)
    {
        //var pagamento = RestService.For<IServicoPagamento>(Environment.GetEnvironmentVariable("URL_API_PAGAMENTOS")!);
        //var resultado = await pagamento.ObterPagamentoPorId(idPagamento);
        var resultado = await servicoPagamento.ObterPagamentoPorId(idPagamento);

        return Ok(resultado);
    }

    [HttpPost("{id}/pagamentos")]
    public async Task<IActionResult> CriarPagamento(
        [FromRoute] int id,
        [FromBody] PagamentoRequisicao requisicao)
    {
        var resultado = await servicoPagamento.CriarPagamento(requisicao);

        if (!resultado.Sucesso)
            return BadRequest(resultado.Erros);

        return CreatedAtAction(nameof(ObterPagamento), new { id, idPagamento = resultado.IdPagamento }, resultado);
    }
}