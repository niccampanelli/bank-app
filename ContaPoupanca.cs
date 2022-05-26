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

        public ContaPoupanca(string nome, decimal credito) : base(nome, credito)
        {
            Random rand = new Random();
            Codigo = rand.Next(1000, 9999).ToString();
            Nome = nome;
            Taxa = 0.5M;
            Credito = credito;
            Rendimento = 0.12M;
        }

        public override decimal Depositar(decimal quantidade)
        {
            Console.WriteLine($"\nRendimento de {Rendimento}% acrescentado ao saldo.\n" +
                $"R${Saldo * (Rendimento / 100)} de rendimento.");
            Saldo += Saldo * (Rendimento / 100);
            Saldo += quantidade;
            Console.WriteLine("\nDepósito realizado com sucesso!\n");
            return Saldo;
        }

        public override decimal Sacar(decimal quantidade)
        {
            if ((Saldo - quantidade) > -(Credito))
            {
                Console.WriteLine($"\nRendimento de {Rendimento}% acrescentado ao saldo.\n" +
                    $"R${Saldo * (Rendimento / 100)} de rendimento.");
                Saldo += Saldo * (Rendimento / 100);
                Saldo -= Math.Abs(Saldo) * (Taxa / 100);
                Saldo -= quantidade;
                Console.WriteLine($"Taxa de {Taxa}% aplicada.");
                Console.WriteLine("\nSaque realizado com sucesso!\n");
            }
            else
            {
                Console.WriteLine("\nLimite de crédito excedido!\n");
                if (Saldo - (-(Credito)) != 0)
                {
                    Console.WriteLine($"Valor disponível para saque: {Saldo - (-(Credito))}");
                }
            }
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
