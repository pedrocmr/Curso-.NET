using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           // Cliente pedro = new Cliente();

           // pedro.nome = "Pedro";
           // pedro.profissao = "Dev";
           // pedro.cpf = "000.000.000-00";

            ContaCorrente contaPedro = new ContaCorrente();

            // contaPedro.titular = pedro;

            //contaPedro.titular = new Cliente();

            contaPedro.saldo = 100;
            contaPedro.agencia = 2193;
            contaPedro.conta = 3123;
            //contaPedro.titular.nome = "Pedro Camara";
            //contaPedro.titular.cpf = "123.456.789-10";


            if (contaPedro.titular == null)
            {
                Console.WriteLine("referencia nula");

            }

            Console.WriteLine(contaPedro.titular);
            Console.WriteLine(contaPedro.titular);

            Console.ReadLine();
        }
    }
}
