using System.IO;
using System.Collections.Generic;
using System;
using Modelos;

namespace TAREFA3
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
        Método que retorna todos os ceps do arquivo CSV
        O método testa se o arquivo existe e caso o contrário, ele retorna uma mensagem de erro e a aplicação termina
        */
        public List<string> lerTodosOsCeps()
        {
            try
            {
                using (var leitor = new StreamReader(this.caminhoArquivo))
                {
                    List<string> listaDeCeps = new List<string>();
                    //Pulando o cabeçalho
                    this.cabecalho = leitor.ReadLine();
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        var valores = linha.Split(";");
                        string cep = valores[0];
                        listaDeCeps.Add(cep);
                    }
                    return listaDeCeps;
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
