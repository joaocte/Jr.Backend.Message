﻿using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Pessoa.Dto
{
    public class NomeCompleto
    {
        public string Nome { get; }
        public string Sobrenome { get; }

        [JsonConstructor]
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}