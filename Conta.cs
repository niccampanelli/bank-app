using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Conta
    {

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Saldo { get; set; }
        public decimal Credito { get; set; }
        public decimal Taxa { get; set; }

        public Conta(string nome, decimal credito)
        {
            Random rand = new Random();
            Codigo = rand.Next(1000, 9999).ToString();
            Nome = nome;
            Credito = credito;
            Taxa = 0.5M;
        }

        public virtual decimal Depositar(decimal quantidade)
        {
            Saldo += quantidade;
            return Saldo;
        }

        public virtual decimal Sacar(decimal quantidade)
        {
            if(Saldo > -(Credito))
            {
                Saldo -= Math.Abs(Saldo) * (Taxa / 100);
                Saldo -= quantidade;
                Console.WriteLine($"Taxa de {Taxa}% aplicada.");
            }
            else
            {
                Console.WriteLine("\nLimite de crédito excedido!\n");
            }
            return Saldo;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine(
                "\nCódigo da conta: "+Codigo+
                "\nNome: " +Nome+
                "\nSaldo: R$ "+Saldo+
                "\nCrédito: R$ "+Credito+
                "\n"
            );
        }

    }
}
