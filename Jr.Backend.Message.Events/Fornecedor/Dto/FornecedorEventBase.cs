using Jr.Backend.Libs.Messaging.Abstractions.Interfaces;
using Jr.Backend.Message.Events.Fornecedor.Comum;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Fornecedor
{
    public abstract class FornecedorEventBase : IEvent
    {
        public string Celular { get; }

        public string CNAE { get; }
        public string Cnpj { get; }
        public DateTime DataCadastro { get; }
        public IEnumerable<string> EmailContato { get; }
        public IEnumerable<string> EmailFatura { get; }

        public List<string> Enderecos { get; }
        public InformacoesBancarias InformacoesBancarias { get; }

        public string NomeContato { get; }
        public string NomeRazaoSocial { get; }

        public string Status { get; }

        public string Telefone { get; }

        public bool AceiteTermosDeUso { get; }

        [JsonConstructor]
        public FornecedorEventBase(string celular, string cNAE, string cnpj, DateTime dataCadastro, IEnumerable<string> emailContato, IEnumerable<string> emailFatura, List<string> enderecos, InformacoesBancarias informacoesBancarias, string nomeContato, string nomeRazaoSocial, string status, string telefone, bool aceiteTermosDeUso)
        {
            Celular = celular;
            CNAE = cNAE;
            Cnpj = cnpj;
            DataCadastro = dataCadastro;
            EmailContato = emailContato;
            EmailFatura = emailFatura;
            Enderecos = enderecos;
            InformacoesBancarias = informacoesBancarias;
            NomeContato = nomeContato;
            NomeRazaoSocial = nomeRazaoSocial;
            Status = status;
            Telefone = telefone;
            AceiteTermosDeUso = aceiteTermosDeUso;
        }
    }
}