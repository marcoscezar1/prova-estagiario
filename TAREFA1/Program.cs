﻿using System;
using System.Collections.Generic;
using EntradaESaida;
using Modelos;

namespace TAREFA1
{
    class Program
    {
        static void Main(string[] args)
        {
            LeitorCSV leitorCSVMapa = new LeitorCSV(@"../mapa.csv");
            EscritorCSV escritorCSVNovoMapa = new EscritorCSV(@"mapa2.csv");
            List<Cidade> linhasAntigas = leitorCSVMapa.LerTodasAsLinhas();
            
            List<Cidade> linhasNovas = new List<Cidade> ();
            foreach(Cidade cidade in linhasAntigas){
                Cidade novaCidade = new Cidade(cidade.getCidade(), cidade.getPopulacao() * 2 );
                linhasNovas.Add(novaCidade);
            }
            escritorCSVNovoMapa.EscreverTodasAsLinhas(leitorCSVMapa.getCabecalho(), linhasNovas);
        }
    }
}
