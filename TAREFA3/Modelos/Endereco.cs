using System.Text.Json.Serialization;

namespace Modelos
{
    /*
        Classe para guardar os dados da requisição da API da Via Cep
        Cada atributo terá um atributo do objeto contido no arquivo JSON
    */
    class Endereco
    {

        [JsonPropertyName("cep")]
        public string Cep { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }
        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }
        [JsonPropertyName("uf")]
        public string Uf { get; set; }
        [JsonPropertyName("unidade")]
        public string Unidade { get; set; }
        [JsonPropertyName("ibge")]
        public string Ibge { get; set; }
        [JsonPropertyName("gia")]
        public string Gia { get; set; }

    }
}

