using Demo.Refit.Pagamentos.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Refit.Pagamentos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PagamentosController : ControllerBase
{
    private readonly List<DadosPagamento> pagamentos = new()
    {
        new DadosPagamento(1, 100, 11),
        new DadosPagamento(2, 200, 22),
        new DadosPagamento(3, 300, 33),
    };

    [HttpGet("{id}", Name = nameof(ObterPorId))]
    public IActionResult ObterPorId([FromRoute] int id)
    {
        var payment = pagamentos.FirstOrDefault(p => p.Id == id);

        if (payment is null)
            return NotFound();

        return Ok(payment);
    }

    [HttpPost]
    public IActionResult CriarPagamento([FromBody] PagamentoEntrada requisicao)
    {
        var randomId = new Random().Next(1, 3);

        return CreatedAtAction(nameof(ObterPorId), new { id = randomId }, new PagamentoSaida(randomId, true, new List<string>()));
    }
}