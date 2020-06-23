using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelos;
using Excecoes;
using ClientesHttp;
using EntradaESaida;

namespace TAREFA3
{
    class Program
    {
        static async Task Main(string[] args)
        {


            LeitorCSV leitorDeCeps = new LeitorCSV(@"../CEPs.csv");
            EscritorCSV EscritordeCeps = new EscritorCSV(@"CEPs2.csv");
            List<string> listaDeCeps = leitorDeCeps.LerTodosOsCeps();
            ClienteViaCep cliente = new ClienteViaCep();
            List<Endereco> listaDeEnderecos = new List<Endereco>();
            foreach (string cep in listaDeCeps)
            {
                try
                {
                    Endereco novoEndereco = await cliente.Busca(cep);
                    listaDeEnderecos.Add(novoEndereco);
                }
                catch (CepInvalidoException e)
                {
                    Console.WriteLine("CEP com formato inválido");
                }
                catch (Exception e2)
                {
                    Console.WriteLine("Não foi possível realizar a requisiçao");
                }


            }
            EscritordeCeps.EscreverTodasAsLinhas(leitorDeCeps.getCabecalho(), listaDeEnderecos);

        }
    }
}

