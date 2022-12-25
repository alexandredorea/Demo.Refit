using Demo.Refit.Pedidos.Servicos.Interfaces;
using Refit;

namespace Demo.Refit.Pedidos.Servicos.Extensoes;

public static class ColecoesServicosExtensoes
{
    private static readonly string ConfigExternaPagamentosApi = Environment.GetEnvironmentVariable("URL_API_PAGAMENTOS")!;

    public static IServiceCollection AdicionarClientesApisExternas(this IServiceCollection servicos, IConfiguration configuracao)
    {
        var urlApiPagamento = ConfigExternaPagamentosApi;

        servicos.AddRefitClient<IServicoPagamento>()
            .ConfigureHttpClient(config =>
            {
                config.BaseAddress = new Uri(urlApiPagamento);
            });
        return servicos;
    }
}