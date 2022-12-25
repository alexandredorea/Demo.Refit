namespace Demo.Refit.Pedidos.Servicos.Modelos;

public class PagamentoRequisicao
{
    public int IdPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public string? NumeroCartaoCredito { get; set; }
    public string? CodigoSeguranca { get; set; }
}