using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaDoPedro = new ContaCorrente();

            contaDoPedro.titular = "Pedro";
            contaDoPedro.saldo = 100;
            contaDoPedro.agencia = 2193;


            Console.WriteLine(contaDoPedro.titular);
            Console.WriteLine(contaDoPedro.saldo);

            

            Console.ReadLine();
        }
    }
}
