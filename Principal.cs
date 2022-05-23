using System;

namespace BankApp
{
    class Principal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao caixa eletrônico!");
            Console.WriteLine("------------------------------\n");

            bool Lifecycle1 = true;

            while (Lifecycle1)
            {
                Console.WriteLine("Escolha um tipo de conta para começar:" +
                    "\n(1) Conta corrente" +
                    "\n(2) Conta poupança" +
                    "\n(3) Conta especial" +
                    "\n(4) Cancelar");

                string TipoDeConta = Console.ReadLine();

                switch (TipoDeConta)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        Console.WriteLine("Encerrando aplicação...");
                        Lifecycle1 = false;
                        break;

                    default:
                        Console.WriteLine("Tipo de conta inválido. Digite o número da opção desejada.");
                        break;
                }
            }

        }
    }
}
