using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Modelos;

namespace TAREFA3
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
        public async Task<Endereco> Busca(string cep){             
             var httpResponse = await clienteHttp.GetAsync($"{urlBase}{cep}/json/");
             if(httpResponse.IsSuccessStatusCode == false){
                 throw new Exception("Não foi possível acessar");
             }
             var conteudoNoFormatoJson = await httpResponse.Content.ReadAsStreamAsync();
             var conteudoNoFormatoEndereco = await JsonSerializer.DeserializeAsync<Endereco>(conteudoNoFormatoJson);
             return conteudoNoFormatoEndereco;
        }
       

    }
}