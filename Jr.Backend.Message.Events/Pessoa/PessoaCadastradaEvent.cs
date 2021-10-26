using Jr.Backend.Libs.Messaging.Abstractions.Interfaces;
using Jr.Backend.Message.Events.Pessoa.Dto;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Pessoa
{
    public class PessoaCadastradaEvent : IEvent
    {
        public NomeCompleto NomeCompleto { get; }

        public IList<Endereco> Enderecos { get; }

        public Documentos Documentos { get; }

        [JsonConstructor]
        public PessoaCadastradaEvent(NomeCompleto nomeCompleto, IList<Endereco> enderecos, Documentos documentos)
        {
            NomeCompleto = nomeCompleto;
            Enderecos = enderecos;
            Documentos = documentos;
        }
    }
}