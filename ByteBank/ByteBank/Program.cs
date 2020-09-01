using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor pedro = new Diretor(5000, "121.532.131-32");
            pedro.Nome = "Pedro";
            pedro.Senha = "1501";

            GerenteDeConta rafael = new GerenteDeConta(3000, "109.312.323-21");
            rafael.Nome = "Rafael";
            rafael.Senha = "1997";

            sistemaInterno.Logar(rafael, "1999");

            sistemaInterno.Logar(pedro, "1501");
            sistemaInterno.Logar(pedro, "1844");

        }
            




        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer mikael = new Designer(1000 ,"213.321.325-42");
            mikael.Nome = "Mikael";

            Auxiliar roberto = new Auxiliar(800, "313.546.643-12");
            roberto.Nome = "Roberto";

            Diretor pedro = new Diretor(5000, "121.532.131-32");
            pedro.Nome = "Pedro";

            GerenteDeConta rafael = new GerenteDeConta(3000, "109.312.323-21");
            rafael.Nome = "Rafael";

            gerenciadorBonificacao.Registrar(mikael);
            gerenciadorBonificacao.Registrar(roberto);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(rafael);

            Console.WriteLine("Total bonificacao: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
