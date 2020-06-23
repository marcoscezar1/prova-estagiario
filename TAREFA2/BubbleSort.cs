using System;
using System.Collections.Generic;
using Modelos;

namespace Testes
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
            for (int i = 1; i < listaDeCidades.Count - 1; i++)
            {
                for (int j = 1; j < listaDeCidades.Count - 1; j++)
                {
                    Cidade elementoEscolhido = listaDeCidades[j];
                    Cidade proximoElemento = listaDeCidades[j + 1];
                    if (elementoEscolhido.getPopulacao() > proximoElemento.getPopulacao())
                    {
                        listaDeCidades[j] = proximoElemento;
                        listaDeCidades[j + 1] = elementoEscolhido;
                    }

                }
            }
        }
    }
}