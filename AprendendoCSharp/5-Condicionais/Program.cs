using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5- exercicio");

            int idade = 17;


            bool testIdade = idade >= 18;



            if(testIdade == true)
            {
                Console.WriteLine("Entra ai parceiro");
            }
            else
            {
                Console.WriteLine("Vai entrar nao parceiro");
            }





            Console.ReadLine();
        }
    }
}
