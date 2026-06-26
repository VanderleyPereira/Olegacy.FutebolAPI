using Microsoft.Extensions.Caching.Memory;
using Olegacy.FutebolAPI.Clients;
using Olegacy.FutebolAPI.Models.Responses;

namespace Olegacy.FutebolAPI.Services
{
    public class BrasileiraoService : IBrasileiraoService
    {
        private readonly IApiFutebolClient _client;
        private readonly IMemoryCache _cache;

        public BrasileiraoService(IApiFutebolClient client, IMemoryCache cache)
        {
            _client = client;
            _cache = cache;
        }

        public async Task<List<TabelaItemResponse>> GetTabelaAsync()
        {
            return await _cache.GetOrCreateAsync("tabela", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
                return await _client.GetTabelaAsync();
            }) ?? [];
        }

        public async Task<List<RodadaResponse>> GetRodadasAsync()
        {
            return await _cache.GetOrCreateAsync("rodadas", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
                return await _client.GetRodadasAsync();
            }) ?? [];
        }

        public async Task<RodadaResponse> GetRodadaAtualAsync()
        {
            return await _cache.GetOrCreateAsync("rodada_atual", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(2);
                return await _client.GetRodadaAtualAsync();
            }) ?? new RodadaResponse();
        }
    }
}