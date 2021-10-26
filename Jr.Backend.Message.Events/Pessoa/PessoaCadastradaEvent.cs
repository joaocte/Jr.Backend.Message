﻿using Jr.Backend.Libs.Messaging.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Jr.Backend.Message.Events.Pessoa
{
    public class PessoaCadastradaEvent : IEvent
    {
        public string Nome { get; }

        public string Sobrenome { get; }

        public IList<Endereco> Enderecos { get; }

        public string Cpf { get; }
        public string Rg { get; }
        public string TituloEleitoral { get; }

        public PessoaCadastradaEvent(string nome, string sobrenome, IList<Endereco> enderecos, string cpf, string rg, string tituloEleitoral)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Enderecos = enderecos;
            Cpf = cpf;
            Rg = rg;
            TituloEleitoral = tituloEleitoral;
        }
    }
}