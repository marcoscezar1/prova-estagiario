using System;
using System.Collections.Generic;
using Modelos;

namespace TAREFA2
{
    class Program
    {
        static void Main(string[] args)
        {
            LeitorCSV leitorCSVMapa = new LeitorCSV(@"../mapa.csv");
            EscritorCSV escritorCSVNovoMapa = new EscritorCSV(@"mapa2.csv");
            List<Cidade> listaDeCidades = leitorCSVMapa.lerTodasAsLinhas();
            
            BubbleSort ordenador = new BubbleSort();
            ordenador.orderna(listaDeCidades);
            Console.WriteLine(listaDeCidades[0].getPopulacao());
            
            escritorCSVNovoMapa.EscreverTodasAsLinhas(leitorCSVMapa.getCabecalho(), listaDeCidades);
        }
    }
}