

namespace _06_ByteBank
{
    public class ContaCorrente
    {

        private Cliente _titular;
        private int _conta;
        private int _agencia;



        public static int TotalDeContas { get; private set;}

        


        public ContaCorrente(int conta, int agencia)
        {
            _conta = conta;
            _agencia = agencia;
            TotalDeContas++;
        }



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
        public int Agencia 
        { 
            get
            {
                return _agencia;
            }
            set
            {
                _agencia = value;
            }
        }
       
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
