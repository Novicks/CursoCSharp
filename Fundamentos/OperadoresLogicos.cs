using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            // && || ^ esses são operadores primarios que operam em 2 operadores;

            // podemos colocar var a baixo.
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 32 {0}", comprouTv32);

            // ! isso é uma negação logica e operador unario, pois inverte o valor
            // determinado operando.
            Console.WriteLine("Mais saúdavel? {0}", !comprouSorvete);
        }
    }
}
