

namespace _05_ByteBank
{
    public class ContaCorrente
    {

        private Cliente _titular;
        private int _conta;
        private int _agencia;
        






        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
                    
                    
        }
        public int Conta 
        {   get
            {
                return _conta;
            }
            set
            {
                _conta = value;
            }
        }
        public int Agencia { get; set; }
       
        private double _saldo = 100;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0 )
                {
                    return;
                }
                _saldo = value;

            }
        }


        public double GetSaldo()
        {
            return _saldo;
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)  
            {
                return;
            }
            
                _saldo = valor;
            
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }

        }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;

            }
        }

    }
}
