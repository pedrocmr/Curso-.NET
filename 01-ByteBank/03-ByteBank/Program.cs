using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaPedro = new ContaCorrente();

            bool resultadoSaque = contaPedro.Sacar(90);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaPedro.saldo);

            contaPedro.Depositar(1000);

            Console.WriteLine(contaPedro.saldo);

            ContaCorrente contaRafa = new ContaCorrente();

            Console.WriteLine(contaRafa.saldo);

            contaPedro.Transferir(400, contaRafa);


            Console.WriteLine(contaPedro.saldo);
            Console.WriteLine(contaRafa.saldo);


            Console.ReadLine();
        }
    }
}
