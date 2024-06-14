using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar() {
            double nota = 7.0;
            // Verdadeiro vai executar essa linha
            if (nota >= 7.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação...");
                // Falso executa a condição else
            } else {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Que feio...");
            }
        }
    }
}
