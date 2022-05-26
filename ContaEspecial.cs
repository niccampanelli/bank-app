using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ContaEspecial: Conta
    {
        public ContaEspecial(string nome, decimal credito): base(nome, credito)
        {
            Random rand = new Random();
            Codigo = rand.Next(1000, 9999).ToString();
            Nome = nome;
            Credito = credito;
            Taxa = 0.1M;
        }
    }
}
