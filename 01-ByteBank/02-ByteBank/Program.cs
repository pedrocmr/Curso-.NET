using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //diferença entre referencia e valor
            ContaCorrente contaPedro = new ContaCorrente();
            contaPedro.agencia = 2193;

            ContaCorrente contaRafa = new ContaCorrente();
            contaRafa.agencia = 2193;



            Console.WriteLine(contaRafa == contaPedro);

            Console.ReadLine();

        }
    }
}
