using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo private");

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();


            cliente.Nome = "Rafael Figueredo";
            cliente.CPF = "123.456.789-10";
            cliente.Profissao = "Dev";

            conta.Titular = cliente;

            conta.Saldo = 25;
            
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();

        }
    }
}
