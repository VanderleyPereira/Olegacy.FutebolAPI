using System.Text.Json.Serialization;

namespace Olegacy.FutebolAPI.Models.Responses
{
    public class TabelaItemResponse
    {
        [JsonPropertyName("posicao")]
        public int Posicao { get; set; }

        [JsonPropertyName("time")]
        public TimeResponse? Time { get; set; }

        [JsonPropertyName("pontos")]
        public int Pontos { get; set; }

        [JsonPropertyName("jogos")]
        public int Jogos { get; set; }

        [JsonPropertyName("vitorias")]
        public int Vitorias { get; set; }

        [JsonPropertyName("empates")]
        public int Empates { get; set; }

        [JsonPropertyName("derrotas")]
        public int Derrotas { get; set; }

        [JsonPropertyName("saldo_gols")]
        public int SaldoGols { get; set; }
    }

    public class TimeResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("shortName")]
        public string? Sigla { get; set; }

        [JsonPropertyName("badge")]
        public string? Escudo { get; set; }
    }
}