using System.IO;
using System.Collections.Generic;
using System;
using Modelos;

namespace EntradaESaida
{
    class LeitorCSV
    {
        //Atributo que guarda o caminho do arquivo a ser lido
        private string caminhoArquivo;
        private string cabecalho;
        public LeitorCSV(string caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }
        
        public string getCabecalho(){
            return this.cabecalho;
        }

        /*
        Método que retorna todas as linhas do arquvo csv em uma lista de objetos do tipo Cidade
        O método testa se o arquivo existe e caso o contrário, ele retorna uma mensagem de erro e a aplicação termina
        */
        public List<Cidade> LerTodasAsLinhas()
        {
            try
            {
                using (var leitor = new StreamReader(this.caminhoArquivo))
                {
                    List<Cidade> ListaDeCidades = new List<Cidade>();
                    //Pulando o cabeçalho
                    this.cabecalho = leitor.ReadLine();
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        var valores = linha.Split(";");
                        Cidade novaCidade = new Cidade(valores[0], Int32.Parse(valores[1]));
                        ListaDeCidades.Add(novaCidade);
                    }
                    return ListaDeCidades;
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não encontrado");
                Environment.Exit(0);
                return null;
            }
        }
    }
}
