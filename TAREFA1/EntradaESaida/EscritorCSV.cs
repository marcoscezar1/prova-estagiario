using System.IO;
using System.Collections.Generic;
using Modelos;
using System;

namespace EntradaESaida
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
        public int EscreverTodasAsLinhas(string cabecalho, List<Cidade> listaDeCidades)
        {
            if (!listaDeCidades.Equals(null))
            {
                using (var escritor = new StreamWriter(caminhoArquivo))
                {
                    escritor.WriteLine(cabecalho);
                    foreach (Cidade cidade in listaDeCidades)
                    {
                        string linha = $"{cidade.getCidade()}; {cidade.getPopulacao()}";
                        escritor.WriteLine(linha);
                    }
                    return 1;
                }
            }
            return 0;
        }
    }
}