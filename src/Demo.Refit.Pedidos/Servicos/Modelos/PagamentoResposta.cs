namespace Demo.Refit.Pedidos.Servicos.Modelos;

public class PagamentoResposta
{
    public PagamentoResposta(int idPagamento, bool success, List<string> errors)
    {
        IdPagamento = idPagamento;
        Sucesso = success;
        Erros = errors;
    }

    public int IdPagamento { get; private set; }
    public bool Sucesso { get; private set; }
    public List<string> Erros { get; private set; }
}