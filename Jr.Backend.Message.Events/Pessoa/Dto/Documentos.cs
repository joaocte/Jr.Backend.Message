using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Pessoa.Dto
{
    public class Documentos
    {
        public string Cpf { get; }
        public string Rg { get; }
        public string TituloEleitoral { get; }

        [JsonConstructor]
        public Documentos(string cpf, string rg, string tituloEleitoral)
        {
            Cpf = cpf;
            Rg = rg;
            TituloEleitoral = tituloEleitoral;
        }
    }
}