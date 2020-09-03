
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("Agencia possui numero 0, que é inválido. ", nameof(agencia));
            }
            if (numero <= 0 )
            {
                throw new ArgumentException("Numero possui numero 0, que é invalido. ", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
     
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            
            if (_saldo < valor)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                throw new ArgumentException("Valor inválido para a transferencia.", nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
            
        }
    }
}
