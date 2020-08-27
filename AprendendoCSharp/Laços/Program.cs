using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laços");

            int cont = 1;


            double dinheiroPoupanca = 500;





            while (cont <= 10)
            {
                dinheiroPoupanca +=  dinheiroPoupanca * 0.0030;
                Console.WriteLine(dinheiroPoupanca);
                cont++;
                
            }







            Console.ReadLine();
        }
    }
}
