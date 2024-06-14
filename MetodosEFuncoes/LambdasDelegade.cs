using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);   
    internal class LambdasDelegade
    {
        public static void Executar() {
            Operacao sum = (x, y) => (x + y);
            Operacao sub = (x, y) => (x - y);
            Operacao mul = (x, y) => (x * y);
            Operacao div = (x, y) => (x / y);

            Console.WriteLine(sum(3, 2));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mul(12, 8));
            Console.WriteLine(div(9, 3));
        }
    }
}
