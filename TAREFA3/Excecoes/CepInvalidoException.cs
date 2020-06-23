namespace Excecoes
{
    /*
        Classe responsável por realizar as requisições http da api do Via Cep
    */
    public class CepInvalidoException : System.Exception
    {
        string cep;
        public CepInvalidoException() { }
        public CepInvalidoException(string message) : base(message) { }
        public CepInvalidoException(string message, System.Exception inner) : base(message, inner) { }
        protected CepInvalidoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}