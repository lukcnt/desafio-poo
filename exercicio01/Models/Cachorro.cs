using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio01.Models
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Latido");
        }
    }
}