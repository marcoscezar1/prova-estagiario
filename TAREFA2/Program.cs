using System.Collections.Generic;
using EntradaESaida;
using Modelos;
using Ordenadores;

namespace TAREFA2
{
    class Program
    {
        static void Main(string[] args)
        {
            LeitorCSV leitorCSVMapa = new LeitorCSV(@"../mapa.csv");
            EscritorCSV escritorCSVNovoMapa = new EscritorCSV(@"mapa2.csv");
            List<Cidade> listaDeCidades = leitorCSVMapa.LerTodasAsLinhas();
            
            BubbleSort ordenador = new BubbleSort();
            ordenador.orderna(listaDeCidades);
            
            escritorCSVNovoMapa.EscreverTodasAsLinhas(leitorCSVMapa.getCabecalho(), listaDeCidades);
        }
    }
}