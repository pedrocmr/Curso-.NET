using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get;  }


        public SaldoInsuficienteException()
            {
            }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de sacar da conta com o saldo: " + saldo + "o valor de : " + valorSaque)

        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
