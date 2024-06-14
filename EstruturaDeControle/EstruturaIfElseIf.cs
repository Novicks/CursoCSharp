using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar() {
            Console.Write("Digite a nota do aluno: ");
            
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de Honra!");
            } else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0 && nota < 7.0) { //podemos tira essa parte do && nota < 7.0 pois é redundante
                Console.WriteLine("Reprovado");
            } else {
                Console.WriteLine("Te vejo ano que vem...");
            }

            Console.WriteLine("Fim");
        }
    }
}
