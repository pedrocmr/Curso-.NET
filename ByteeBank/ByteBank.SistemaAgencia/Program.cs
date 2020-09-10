using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Security.Policy;
using System.Text.RegularExpressions;
using ByteBank.Modelos.Funcionarios;
using System.Runtime.Serialization.Formatters;
using ByteBank.SistemaAgencia.Extensões;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(5193,674856),
                new ContaCorrente(3214,940324),
                null,
                new ContaCorrente(3214,421432)

            };


            
            


            var contasOrdenadas = contas.Where(conta => conta != null).OrderBy(conta => conta.Numero);
                    
            

            //contas.Sort(); ~> usa o IComparable
           // contas.Sort(new ComparadorContaCorrentePorAgencia());


            foreach (var conta in contasOrdenadas)
            {
                if (conta == null)
                {
                    Console.WriteLine("Conta NULA");
                }
                else
                {
                    Console.WriteLine($"Conta numero: {conta.Numero} e agência: {conta.Agencia}");
                }
                
            }






            Console.ReadLine();
        }


        static void TestaSort()
        {
            var nomes = new List<string>()
            {

                "Rafael",
                "Pedro",
                "Saulo",
                "Roberto"

            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            Console.ReadLine();





            var idades = new List<int>();

            idades.Add(1);
            idades.Add(3123);
            idades.Remove(1);

            idades.AdicionarVarios(3123, 312, 31243, 253, 53);



            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }


        }


        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdade = new ListaDeObject();

            listaDeIdade.AdicionarItem(10);
            listaDeIdade.AdicionarItem(3324);

            for (int i = 0; i < listaDeIdade.Tamanho; i++)
            {
                int idade = (int)listaDeIdade[i];
                Console.WriteLine(idade);
            }

        }


        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDoRafael = new ContaCorrente(2193, 421941);
            lista.AdicionarItem(contaDoRafael);

            ContaCorrente[] contas = new ContaCorrente[]
                {
                    contaDoRafael,
                    new ContaCorrente(2193, 321931),
                    new ContaCorrente(2193, 386351)


                };

            //lista.AdicionarVarios(contas);



            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia}/{itemAtual.Numero}");
            }

            Console.ReadLine();
        }






        static void TestaArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {

                    new ContaCorrente(2193, 321931),
                    new ContaCorrente(2193, 386351),
                    new ContaCorrente(2193, 654654)


                };


            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"O numero da conta {indice}  é {contaAtual.Numero}");
            }


            Console.ReadLine();

            int[] idades = new int[5];


            idades[0] = 10;
            idades[1] = 17;
            idades[2] = 14;
            idades[3] = 20;
            idades[4] = 30;

            int acumulador = 0;


            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine(media);
            Console.ReadLine();
        }











        static void TestaEquals()
        {
            object conta = new ContaCorrente(321321, 321312312);
            object desenvolvedor = new Desenvolvedor("313.312.546-41");

            string contaToString = conta.ToString();

            Console.WriteLine(contaToString);
            Console.WriteLine(conta);





            Cliente rafael_1 = new Cliente();
            rafael_1.CPF = "109.312.542-31";
            rafael_1.Nome = "Rafael";
            rafael_1.Profissao = "Dev";

            Cliente rafael_2 = new Cliente();
            rafael_2.CPF = "109.312.542-31";
            rafael_2.Nome = "Rafael";
            rafael_2.Profissao = "Dev";

            bool testeIgualdade = rafael_1.Equals(rafael_2);

            Console.WriteLine(testeIgualdade);

            Console.ReadLine();
        }

        static  void TestaString()
        {

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Olá me chamo Pedro, meu número é 99758-1947";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado);

            Console.ReadLine();



            string urlteste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlteste.IndexOf("http://www.bytebank.com");

            bool testandoByteBank = urlteste.StartsWith("http://www.bytebank.com");
            Console.WriteLine(testandoByteBank);

            Console.WriteLine(urlteste.Contains("http://www.bytebank.com"));

            Console.ReadLine();

            string urlParametros = "http://www.bytebank.com/?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL teste = new ExtratorValorDeArgumentosURL(urlParametros);

            string extratora = teste.GetValor("moedaDestino");

            Console.WriteLine(extratora);


            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');

            Console.WriteLine(teste.GetValor("VALOR"));
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            Console.ReadLine();


            string textoVazio = "";

            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(indice);

            Console.WriteLine("O tamanho de nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            Console.ReadLine();



        }

        static int SomarVarios(params int[] numeros)
        {
            int contador = 0;

                foreach(int numero in numeros)
                {

                    contador += numero;

                }
            return contador;
        }
        
    }
}
