using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio03.Models
{
    public class ContaCorrente
    {
        public string? NomeCorrentista { get; set; }
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        private double Saldo { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
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

        public void ExibirResumoConta()
        {
            Console.WriteLine($"Correntista: {NomeCorrentista}");
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Agência: {NumeroAgencia}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}