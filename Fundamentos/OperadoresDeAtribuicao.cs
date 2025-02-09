﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresDeAtribuicao
    {
        public static void Executar () {
            var num1 = 3;
            num1 = 7; // por outro valor numa var ja definida, faz com que altere a variaçao.
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1
            b--; // b = b - 1

            Console.WriteLine($"{a} {b}");

            // não se importa muito por agora.
            dynamic c = new System.Dynamic.ExpandoObject ();
            c.nome = "joao";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
