


namespace Olegacy.FutebolAPI
{
    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("unidade")]
        public string Unidade { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("estado")]
        public string Estado { get; set; }
        [JsonProperty("regiao")]
        public string Regiao { get; set; }
        [JsonProperty("ibge")]
        public int Ibge { get; set; }
        [JsonProperty("gia")]
        public int Gia { get; set; }
        [JsonProperty("ddd")]
        public int Ddd { get; set; }
        [JsonProperty("siafi")]
        public int Siafi { get; set; }



    }
}
