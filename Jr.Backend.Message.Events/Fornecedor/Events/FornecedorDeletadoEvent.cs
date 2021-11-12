using Jr.Backend.Message.Events.Fornecedor.Comum;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Fornecedor.Events
{
    public class FornecedorDeletadoEvent : FornecedorEventBase
    {
        [JsonConstructor]
        public FornecedorDeletadoEvent(string celular, string cNAE, string cnpj, DateTime dataCadastro, IEnumerable<string> emailContato, IEnumerable<string> emailFatura, List<string> enderecos, InformacoesBancarias informacoesBancarias, string nomeContato, string nomeRazaoSocial, string status, string telefone, bool aceiteTermosDeUso) : base(celular, cNAE, cnpj, dataCadastro, emailContato, emailFatura, enderecos, informacoesBancarias, nomeContato, nomeRazaoSocial, status, telefone, aceiteTermosDeUso)
        {
        }
    }
}