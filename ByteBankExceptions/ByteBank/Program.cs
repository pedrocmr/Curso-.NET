using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
     class Program
    {
         static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(219,321321);
                conta.Depositar(100);
                conta.Sacar(1000);
                 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento que tá com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro de ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Saldo Insuficiente para completar a operação. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             
            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("O resultado da divisao por 10 e: " + divisor + " é: " + resultado);
        }
            
      

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção qnd divide " + numero + " por " + divisor);
                throw;
            }
         
            
        }
    }
}