using System.Text.Json.Serialization;

namespace Olegacy.FutebolAPI.Models.Responses
{
    public class RodadaResponse
    {
        [JsonPropertyName("number")]
        public int Numero { get; set; }

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("matches")]
        public List<PartidaResponse>? Partidas { get; set; }
    }

    public class PartidaResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("homeTeam")]
        public TimeResponse? TimeMandante { get; set; }

        [JsonPropertyName("awayTeam")]
        public TimeResponse? TimeVisitante { get; set; }

        [JsonPropertyName("score")]
        public PlacarResponse? Placar { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }

    public class PlacarResponse
    {
        [JsonPropertyName("home")]
        public int? Mandante { get; set; }

        [JsonPropertyName("away")]
        public int? Visitante { get; set; }
    }
}