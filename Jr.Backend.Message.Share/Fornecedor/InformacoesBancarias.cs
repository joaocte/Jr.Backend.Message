using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Share.Fornecedor
{
    public class InformacoesBancarias
    {
        public string Agencia { get; }
        public string Banco { get; }
        public string Conta { get; }

        public string TipoConta { get; }

        [JsonConstructor]
        public InformacoesBancarias(string agencia, string banco, string conta, string tipoConta)
        {
            Agencia = agencia;
            Banco = banco;
            Conta = conta;
            TipoConta = tipoConta;
        }
    }
}