using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    internal class ExemplosDeOut
    {
        public static void Executar() {
            Console.WriteLine("Qual valor?");
            string entrada = Console.ReadLine();
            string str = entrada;
            if (int.TryParse(str, out int num)) {
                Console.WriteLine("{0}", num +1);
            }
            else {
                Console.WriteLine("A conversão falhou!");
            };
        }
    }
}
