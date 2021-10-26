namespace Jr.Backend.Message.Events.Cliente
{
    public class Endereco
    {
        public string Logradouro { get; }
        public string Bairro { get; }
        public string Numero { get; }
        public string Estado { get; }
        public string Cidade { get; }
        public string Pais { get; }
        public string Cep { get; }

        public string Complemento { get; }
    }
}