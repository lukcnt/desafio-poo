using aula03.Models;

ContaCorrente conta1 = new ContaCorrente(50);
conta1.Numero = 1234;
conta1.ExibirSaldo();

conta1.Sacar(100);
conta1.ExibirSaldo();