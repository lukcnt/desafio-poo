using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula05_1.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}