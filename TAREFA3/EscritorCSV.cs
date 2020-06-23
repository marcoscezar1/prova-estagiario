using System.IO;
using System.Collections.Generic;
using Modelos;
using System;

namespace TAREFA3
{
    class EscritorCSV
    {
        private string caminhoArquivo;
        public EscritorCSV(string caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }


        //Função que escreve cada item de uma lista em uma linha no padrão csv
        //Ela tem como retorno o status da operação. Com isso é possível saber se ela foi bem sucessedida
        public int EscreverTodasAsLinhas(string cabecalho, List<Endereco> listaDeEnderecos)
        {
            if (!listaDeEnderecos.Equals(null))
            {
                using (var escritor = new StreamWriter(caminhoArquivo))
                {
                    escritor.WriteLine(cabecalho);
                    foreach (Endereco endereco in listaDeEnderecos)
                    {
                        string linha = $"{endereco.Cep}; {endereco.Logradouro}; {endereco.Complemento}; {endereco.Bairro}; {endereco.Localidade};"+ 
                        $"{endereco.Uf}; {endereco.Unidade}; {endereco.Ibge}; {endereco.Bairro}; {endereco.Localidade}; {endereco.Uf}; {endereco.Unidade}; {endereco.Gia}" ;
                        escritor.WriteLine(linha);
                    }
                    return 1;
                }
            }
            return 0;
        }
    }
}