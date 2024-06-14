using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmetricos
    {
        public static void Executar() {
            //preco com desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;
            // var inferida como double

            double total = preco + imposto;
            //poderiamso colocar int total = (int) preco + imposto;
            //Utilizando o metodo cash
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC

            double peso = 85.6;
            double altura = 1.74;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // Numero par ou Ímpar

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
