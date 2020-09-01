using ByteBank.Funcionarios;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario pedro = new Funcionario("123.546.856-43");
            

            pedro.Nome = "Pedro";
            
            pedro.Salario = 500;

            gerenciador.Registrar(pedro);

            Console.WriteLine(pedro.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Diretor saulo = new Diretor();
            saulo.Nome = "Saulo";
            saulo.CPF = "313.321.325-54";
            saulo.Salario = 4000;

            Funcionario helio = saulo;

            Console.WriteLine("A bonificacao de helio é: " + helio.GetBonificacao());
            Console.WriteLine("A bonificacao de saulo é: " + saulo.GetBonificacao());

            gerenciador.Registrar(saulo);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine(saulo.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
