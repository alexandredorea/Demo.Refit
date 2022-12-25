namespace Demo.Refit.Pagamentos.Modelos;

public class PagamentoSaida
{
    public PagamentoSaida(int idPagamento, bool success, List<string> errors)
    {
        IdPagamento = idPagamento;
        Success = success;
        Errors = errors;
    }

    public int IdPagamento { get; private set; }
    public bool Success { get; private set; }
    public List<string> Errors { get; private set; }
}