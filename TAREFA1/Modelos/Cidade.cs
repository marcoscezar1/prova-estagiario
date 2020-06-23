namespace Modelos
{
    /*
        Classe usada de modelo para operações com o arquivo mapa.csv
    */

    class Cidade
    {
        private string nomeDacidade;
        private int populacao;

        public Cidade(string nomeDacidade, int populacao){
            this.nomeDacidade = nomeDacidade;
            this.populacao = populacao;
        }
    }
}