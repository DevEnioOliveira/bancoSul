using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Sul
{
    class Cliente
    {
        private string nome;
        private string dataNasc;
        private string cpf;
        private string endereco;
        private double saldo;
        private Conta conta;

        public string Nome { get => nome; set => nome = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        internal Conta Conta { get => conta; set => conta = value; }
    }
}
