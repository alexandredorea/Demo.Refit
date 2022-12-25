using Demo.Refit.Pedidos.Servicos.Enumeradores;

namespace Demo.Refit.Pedidos.Servicos.Modelos;

public class DadosPagamento
{
    public int Id { get; set; }
    public decimal ValorTotal { get; set; }
    public int IdPedido { get; set; }
    public StatusPagamento Status { get; set; }
    public DateTime DataCriacao { get; set; }
}