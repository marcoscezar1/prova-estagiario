using System;
using System.Collections.Generic;
using Modelos;

namespace TAREFA2
{
    /*
        Classe criada para realizar o BuubleSort 
    */
    class BubbleSort
    {
        /*
            Função ordena uma lista contendo objetos do tipo cidade
            A função não possui retorno e altera a lista passada como parâmetro
        */
        public void orderna(List<Cidade> listaDeCidades)
        {
            for (int i = 0; i < listaDeCidades.Count - 1; i++)
            {
                Console.WriteLine("oi");
                for (int j = 0; j < listaDeCidades.Count - 1; j++)
                {
                    Cidade elementoEscolhido = listaDeCidades[j];
                    Cidade proximoElemento = listaDeCidades[j + 1];
                    if (elementoEscolhido.getPopulacao() > proximoElemento.getPopulacao())
                    {
                        Console.WriteLine(elementoEscolhido.getPopulacao() + " " + proximoElemento.getPopulacao());
                        listaDeCidades[j] = proximoElemento;
                        listaDeCidades[j + 1] = elementoEscolhido;
                    }

                }
            }
        }
    }
}