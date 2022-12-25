using Demo.Refit.Pedidos.Servicos.Modelos;
using Refit;

namespace Demo.Refit.Pedidos.Servicos.Interfaces;

[Headers("Content-Type: application/json")]
public interface IServicoPagamento
{
    [Post("/api/pagamentos")]
    Task<PagamentoResposta> CriarPagamento(PagamentoRequisicao requisicao);

    [Get("/api/pagamentos/{id}")]
    Task<DadosPagamento> ObterPagamentoPorId([AliasAs("id")] int idPagamento);
}