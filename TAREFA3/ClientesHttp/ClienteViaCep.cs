using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Modelos;
using System.Text.RegularExpressions;
using Excecoes;

namespace ClientesHttp
{
    /*
        Classe responsável por realizar as requisições http da api do Via Cep
    */
    class ClienteViaCep
    {
        private const string urlBase = "https://viacep.com.br/ws/";
        private readonly HttpClient clienteHttp = new HttpClient();

        /*
            Método que busca um cep específico
            Tem como o retorno um objeto da classe Endereçoi
        */

        private string FormataCEP(string cep){
            cep = cep.Replace(" ", "");
            cep = cep.Replace("-", "");
            return cep;
        }
        public async Task<Endereco> Busca(string cep)
        {
            Regex expressaoRegular = new Regex(@"^\d{5}-? ?\d{3}$");
            if (!expressaoRegular.IsMatch(cep))
            {
                throw new CepInvalidoException("CEP inválido.");
            }
            cep = FormataCEP(cep);
            var httpResponse = await clienteHttp.GetAsync($"{urlBase}{cep}/json/");
            if (httpResponse.IsSuccessStatusCode == false)
            {
                throw new Exception("Não foi possível acessar");
            }
            var conteudoNoFormatoJson = await httpResponse.Content.ReadAsStreamAsync();
            var conteudoNoFormatoEndereco = await JsonSerializer.DeserializeAsync<Endereco>(conteudoNoFormatoJson);
            return conteudoNoFormatoEndereco;
        }


    }
}