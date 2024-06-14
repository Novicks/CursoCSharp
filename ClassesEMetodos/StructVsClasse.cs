using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    internal class StructVsClasse
    {
        public static void Executar() {
            // Atribuição por copia de valor
            SPonto ponto1 = new SPonto {X=1, Y=3};
            SPonto copiaPonto1 = ponto1; // Atribuição por valor!! a copia do valor e atribuido a uma variavel
            ponto1.X = 3; // Bom para paradigma funcional. Copia por valor é não por Referencia.

            Console.WriteLine("Ponto 1 X: {0}" ,ponto1.X);
            Console.WriteLine("Copia ponto 1 X: {0}", copiaPonto1.X);

            // Atribuição por referencia classe
            CPonto ponto2 = new CPonto { X = 1, Y = 2 };
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X: {0}",ponto2.X);
            Console.WriteLine("Copia ponto 2 X: {0}", copiaPonto2.X);
        }
    }
}
