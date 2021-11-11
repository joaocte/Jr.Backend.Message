using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Fornecedor.Comum.Endereco
{
    public class EnderecoComercial : Endereco
    {
        [JsonConstructor]
        public EnderecoComercial(string bairro, string cep, string cidade, string complemento, string estado, string logradouro, string numero) : base(bairro, cep, cidade, complemento, estado, logradouro, numero)
        {
        }
    }
}