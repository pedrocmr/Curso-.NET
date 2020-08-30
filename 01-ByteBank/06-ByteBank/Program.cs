using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaPedro = new ContaCorrente(181, 2193);
            Console.WriteLine(contaPedro.Agencia);
            Console.WriteLine(ContaCorrente.TotalDeContas);
            Console.ReadLine();
        }
    }
}
