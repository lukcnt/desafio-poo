using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio02.Models
{
    public class Livro
    {
        public string? Nome { get; set; }
        public List<Autor> autores = new List<Autor>();
    }
}