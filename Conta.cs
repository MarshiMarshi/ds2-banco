using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds2_banco
{
    class Conta
    {
        public Conta(Cliente cliente)
        {
            this.titular = cliente;
        }

        public int numero;
        public Cliente titular;
        public double saldo;
        public double limite;

        public void sacar(double valor)
        {
            
        }

        public void depositar(double valor)
        {

        }
    }
}
