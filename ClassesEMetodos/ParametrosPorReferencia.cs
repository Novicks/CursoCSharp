using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlternarRef(ref int numero) {
            numero = numero + 1000;
        }
        public static void AlternarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        // Out é unidirecional.

        // Ref tem que inicializar a variavel para passa para outro método
        public static void Executar() {
            int a = 3;
            AlternarRef(ref a);
            Console.WriteLine(a);

            //int b = 2;

            AlternarOut(out int b, out int c) ;
            Console.WriteLine($"{b} {c}");
        }
    }
}
