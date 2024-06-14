using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIF
    {
        public static void Executar() {
            bool bomComportamento = false;
            bool certificado = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N)");
            entrada = Console.ReadLine();

            Console.WriteLine("O aluno é um aluno exemplar (S/N)");
            entrada = Console.ReadLine();

            // if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada = "s";
            bomComportamento = entrada.ToLower() == "s";

            certificado = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento && certificado) {
                Console.WriteLine("Quadro de Honra!");
                Console.WriteLine("Parabéns pelo certificado de aluno exemplar!");
            }
        }
    }
}
