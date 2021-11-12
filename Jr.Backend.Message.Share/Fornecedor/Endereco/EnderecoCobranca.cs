using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Share.Fornecedor.Endereco
{
    public class EnderecoCobranca : Endereco
    {
        [JsonConstructor]
        public EnderecoCobranca(string bairro, string cep, string cidade, string complemento, string estado, string logradouro, string numero) : base(bairro, cep, cidade, complemento, estado, logradouro, numero)
        {
        }
    }
}