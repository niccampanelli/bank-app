using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ContaPoupanca: Conta
    {
        public decimal Rendimento { get; set; }

        public ContaPoupanca(string nome): base(nome)
        {
            Random rand = new Random();
            Codigo = rand.Next(1000, 9999).ToString();
            Nome = nome;
            Taxa = 0.5M;
            Rendimento = 0.1M;
        }

        public override decimal Depositar(decimal quantidade)
        {
            Console.WriteLine($"\nRendimento de {Rendimento}% acrescentado ao saldo.\n" +
                $"R${Saldo * (Rendimento / 100)} de rendimento.");
            Saldo += Saldo * (Rendimento / 100);
            Saldo += quantidade;
            return Saldo;
        }

        public override decimal Sacar(decimal quantidade)
        {
            Console.WriteLine($"\nRendimento de {Rendimento}% acrescentado ao saldo.\n" +
                $"R${Saldo * (Rendimento / 100)} de rendimento.");
            Saldo += Saldo * (Rendimento / 100);
            Saldo -= quantidade + (Saldo * (Taxa / 100));
            return Saldo;
        }

        public override void Mostrar()
        {
            Console.WriteLine(
                "\nCódigo da conta: " + Codigo +
                "\nNome: " + Nome +
                "\nSaldo: R$ " + Saldo +
                "\nCrédito: R$ " + Credito +
                "\nTaxa de rendimento: " + Rendimento + "%\n"
            );
        }

    }
}
