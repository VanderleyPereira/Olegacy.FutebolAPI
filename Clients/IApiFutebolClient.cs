using Refit;
using Olegacy.FutebolAPI.Models.Responses;

namespace Olegacy.FutebolAPI.Clients
{
    public interface IApiFutebolClient
    {
        [Get("/brasileirao/tabela?serie=a")]
        Task<List<TabelaItemResponse>> GetTabelaAsync();

        [Get("/brasileirao/rodadas?serie=a")]
        Task<List<RodadaResponse>> GetRodadasAsync();

        [Get("/brasileirao/rodada-atual?serie=a")]
        Task<RodadaResponse> GetRodadaAtualAsync();
    }
}