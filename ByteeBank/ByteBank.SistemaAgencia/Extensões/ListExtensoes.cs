using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensões
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void TesteGenerico<T2>(this string texto)
        {

        }

         static void Teste()
        {
            List<int> dia = new List<int>();

            dia.Add(31);

            dia.AdicionarVarios(321, 32, 4, 1);

        }
    }
}
