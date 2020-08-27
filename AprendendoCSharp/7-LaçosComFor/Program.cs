using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_LaçosComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;

            double dinheiroConta = 500;
            int ano;
            double percentualRend = 1.0036;

            Console.WriteLine("Laços encadeados");

            for (ano = 1; ano <= 5; ano++)
            {
                for (contador = 1; contador <= 12; contador++)
                {
                    dinheiroConta *= percentualRend;
                    Console.WriteLine("O dinheiro no mês " + contador + " do ano " + ano + " foi de: R$ " + dinheiroConta);

                }
                percentualRend += 0.0010;
            }

            Console.ReadLine();

        }
    }
}
