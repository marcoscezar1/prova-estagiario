using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelos;

namespace TAREFA3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            LeitorCSV leitorDeCeps = new LeitorCSV(@"../CEPs.csv");
            EscritorCSV EscritordeCeps = new EscritorCSV(@"CEPs2.csv");
            List<string> listaDeCeps = leitorDeCeps.lerTodosOsCeps();
            ClienteViaCep cliente = new ClienteViaCep();
            List<Endereco> listaDeEnderecos = new List<Endereco>();
            foreach(string Cep in listaDeCeps){
                Endereco novoEndereco = await cliente.Busca(Cep);
                listaDeEnderecos.Add(novoEndereco);
            }
            EscritordeCeps.EscreverTodasAsLinhas(leitorDeCeps.getCabecalho(), listaDeEnderecos);

        }
    }
}
