using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Sul
{
    class Conta
    {
        private int idCliente;
        private int agencia;
        private int contaCorrente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int Agencia { get => agencia; set => agencia = value; }
        public int ContaCorrente { get => contaCorrente; set => contaCorrente = value; }
    }
}
