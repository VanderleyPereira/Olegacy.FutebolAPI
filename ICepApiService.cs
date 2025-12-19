
namespace Olegacy.FutebolAPI
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetCepInfoAsync(string cep);
    }

    internal class GetAttribute : Attribute
    {
        private string v;
        public GetAttribute(string v)
        {
            this.v = v;
        }
    }
}
