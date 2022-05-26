using System;

namespace BankApp
{
    class Principal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------");
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

                        Console.WriteLine("\nConta corrente selecionada.");
                        Console.WriteLine("Digite seu nome completo:");
                        string NomeContaCorrente = Console.ReadLine();

                        Console.WriteLine("\nAgora, escolha quanto crédito sua conta possuirá:");
                        string CreditoContaCorrente = Console.ReadLine();

                        Conta ContaCorrente = new Conta(NomeContaCorrente, decimal.Parse(CreditoContaCorrente));

                        Console.WriteLine("\nConta corrente criada com sucesso!\nInformações da conta criada:");
                        ContaCorrente.Mostrar();

                        bool CicloContaCorrente = true;

                        while (CicloContaCorrente)
                        {
                            Console.WriteLine("\nEscolha a operação que deseja realizar:" +
                                "\n(1) Consultar saldo" +
                                "\n(2) Consultar crédito" +
                                "\n(3) Sacar dinheiro" +
                                "\n(4) Realizar depósito" +
                                "\n(5) Sair");

                            string OperacaoContaCorrente = Console.ReadLine();

                            switch (OperacaoContaCorrente)
                            {
                                case "1":
                                    Console.WriteLine("\nSeu saldo atual é:\n" +
                                        "R$ "+ ContaCorrente.Saldo);
                                    break;

                                case "2":
                                    Console.WriteLine("\nSeu crédito atual é:\n" +
                                        "R$ " + ContaCorrente.Credito);
                                    break;

                                case "3":
                                    Console.WriteLine("\nDigite o valor em reais a ser sacado:");
                                    string SaqueContaCorrente = Console.ReadLine();
                                    ContaCorrente.Sacar(decimal.Parse(SaqueContaCorrente));
                                    break;

                                case "4":
                                    Console.WriteLine("\nDigite o valor em reais a ser depositado em conta:");
                                    string DepositoContaCorrente = Console.ReadLine();
                                    ContaCorrente.Depositar(decimal.Parse(DepositoContaCorrente));
                                    break;

                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("\nSaindo da conta...\n");
                                    CicloContaCorrente = false;
                                    break;

                                default:
                                    Console.WriteLine("\nOperação inválida. Selecione o número de uma das opções.\n");
                                    break;
                            }
                        }

                        break;

                    case "2":

                        Console.WriteLine("\nConta Poupança selecionada.");
                        Console.WriteLine("Digite seu nome completo:");
                        string NomeContaPoupanca = Console.ReadLine();

                        Console.WriteLine("\nAgora, escolha quanto crédito sua conta possuirá:");
                        string CreditoContaPoupanca = Console.ReadLine();

                        ContaPoupanca ContaPoupanca = new ContaPoupanca(NomeContaPoupanca, decimal.Parse(CreditoContaPoupanca));

                        Console.WriteLine("\nConta poupança criada com sucesso!\nInformações da conta criada:");
                        ContaPoupanca.Mostrar();

                        bool CicloContaPoupanca = true;

                        while (CicloContaPoupanca)
                        {
                            Console.WriteLine("\nEscolha a operação que deseja realizar:" +
                                "\n(1) Consultar saldo" +
                                "\n(2) Consultar crédito" +
                                "\n(3) Sacar dinheiro" +
                                "\n(4) Realizar depósito" +
                                "\n(5) Sair");

                            string OperacaoContaPoupanca = Console.ReadLine();

                            switch (OperacaoContaPoupanca)
                            {
                                case "1":
                                    Console.WriteLine("\nSeu saldo atual é:\n" +
                                        "R$ " + ContaPoupanca.Saldo);
                                    break;

                                case "2":
                                    Console.WriteLine("\nSeu crédito atual é:\n" +
                                        "R$ " + ContaPoupanca.Credito);
                                    break;

                                case "3":
                                    Console.WriteLine("\nDigite o valor em reais a ser sacado:");
                                    string SaqueContaPoupanca = Console.ReadLine();
                                    ContaPoupanca.Sacar(decimal.Parse(SaqueContaPoupanca));
                                    break;

                                case "4":
                                    Console.WriteLine("\nDigite o valor em reais a ser depositado em conta:");
                                    string DepositoContaPoupanca = Console.ReadLine();
                                    ContaPoupanca.Depositar(decimal.Parse(DepositoContaPoupanca));
                                    break;

                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("\nSaindo da conta...\n");
                                    CicloContaPoupanca = false;
                                    break;

                                default:
                                    Console.WriteLine("\nOperação inválida. Selecione o número de uma das opções.\n");
                                    break;
                            }
                        }

                        break;

                    case "3":

                        Console.WriteLine("\nConta especial selecionada.");
                        Console.WriteLine("Digite seu nome completo:");
                        string NomeContaEspecial = Console.ReadLine();

                        Console.WriteLine("\nAgora, escolha quanto crédito sua conta possuirá:");
                        string CreditoContaEspecial = Console.ReadLine();

                        ContaEspecial ContaEspecial = new ContaEspecial(NomeContaEspecial, decimal.Parse(CreditoContaEspecial));

                        Console.WriteLine("\nConta especial criada com sucesso!\nInformações da conta criada:");
                        ContaEspecial.Mostrar();

                        bool CicloContaEspecial = true;

                        while (CicloContaEspecial)
                        {
                            Console.WriteLine("\nEscolha a operação que deseja realizar:" +
                                "\n(1) Consultar saldo" +
                                "\n(2) Consultar crédito" +
                                "\n(3) Sacar dinheiro" +
                                "\n(4) Realizar depósito" +
                                "\n(5) Sair");

                            string OperacaoContaEspecial = Console.ReadLine();

                            switch (OperacaoContaEspecial)
                            {
                                case "1":
                                    Console.WriteLine("\nSeu saldo atual é:\n" +
                                        "R$ " + ContaEspecial.Saldo);
                                    break;

                                case "2":
                                    Console.WriteLine("\nSeu crédito atual é:\n" +
                                        "R$ " + ContaEspecial.Credito);
                                    break;

                                case "3":
                                    Console.WriteLine("\nDigite o valor em reais a ser sacado:");
                                    string SaqueContaEspecial = Console.ReadLine();
                                    ContaEspecial.Sacar(decimal.Parse(SaqueContaEspecial));
                                    break;

                                case "4":
                                    Console.WriteLine("\nDigite o valor em reais a ser depositado em conta:");
                                    string DepositoContaEspecial = Console.ReadLine();
                                    ContaEspecial.Depositar(decimal.Parse(DepositoContaEspecial));
                                    break;

                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("\nSaindo da conta...\n");
                                    CicloContaEspecial = false;
                                    break;

                                default:
                                    Console.WriteLine("\nOperação inválida. Selecione o número de uma das opções.\n");
                                    break;
                            }
                        }

                        break;

                    case "4":
                        Console.WriteLine("\nEncerrando aplicação...\n");
                        Lifecycle1 = false;
                        break;

                    default:
                        Console.WriteLine("\nTipo de conta inválido. Digite o número da opção desejada.\n");
                        break;
                }
            }

        }
    }
}
