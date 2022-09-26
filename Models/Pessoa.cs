using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecoesCSharpBootcampDio.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Descontruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }

    }
}