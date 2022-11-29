using exercicio03.Models;

ContaCorrente c1 = new ContaCorrente();
c1.NomeCorrentista = "Lucas";
c1.NumeroConta = 555166;
c1.NumeroAgencia = 148;
c1.ExibirResumoConta();

Console.Write("\n");

c1.Depositar(500);
c1.ExibirResumoConta();