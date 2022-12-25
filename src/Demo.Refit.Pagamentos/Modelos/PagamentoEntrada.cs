namespace Demo.Refit.Pagamentos.Modelos;

public class PagamentoEntrada
{
    public int IdPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public string? NumeroCartaoCredito { get; set; }
    public string? CodigoSeguranca { get; set; }
}