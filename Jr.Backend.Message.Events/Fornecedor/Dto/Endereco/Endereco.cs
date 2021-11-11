using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Fornecedor.Comum.Endereco
{
    public abstract class Endereco
    {
        public string Bairro { get; }
        public string Cep { get; }

        public string Cidade { get; }

        public string Complemento { get; }

        public string Estado { get; }

        public string Logradouro { get; }
        public string Numero { get; }

        [JsonConstructor]
        public Endereco(string bairro, string cep, string cidade, string complemento, string estado, string logradouro, string numero)
        {
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Complemento = complemento;
            Estado = estado;
            Logradouro = logradouro;
            Numero = numero;
        }
    }
}