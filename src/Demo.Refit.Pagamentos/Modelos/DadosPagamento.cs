using Demo.Refit.Pagamentos.Enumeradores;

namespace Demo.Refit.Pagamentos.Modelos;

public class DadosPagamento
{
    public DadosPagamento(int id, decimal valorTotal, int idPedido)
    {
        Id = id;
        ValorTotal = valorTotal;
        IdPedido = idPedido;
        Status = StatusPagamento.Processando;
        DataCriacao = DateTime.UtcNow;
    }

    public int Id { get; private set; }
    public decimal ValorTotal { get; private set; }
    public int IdPedido { get; private set; }
    public StatusPagamento Status { get; private set; }
    public DateTime DataCriacao { get; private set; }
}