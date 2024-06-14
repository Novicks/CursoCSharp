using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static int SubTracao(this int num, int outroNumero) {
            return num - outroNumero;
        }
    }
    internal class MetodosDeExtensao
    {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.SubTracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.SubTracao(4));
        }
    }
}
