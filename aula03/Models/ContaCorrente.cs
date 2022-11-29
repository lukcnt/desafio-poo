using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula03.Models
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        private decimal Saldo { get; set; }

        public ContaCorrente(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: R$" + Saldo);
        }
    }
}