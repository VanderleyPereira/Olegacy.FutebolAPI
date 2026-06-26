using Olegacy.FutebolAPI.Models.Responses;

namespace Olegacy.FutebolAPI.Services
{
    public interface IBrasileiraoService
    {
        Task<List<TabelaItemResponse>> GetTabelaAsync();
        Task<List<RodadaResponse>> GetRodadasAsync();
        Task<RodadaResponse> GetRodadaAtualAsync();
    }
}