using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        double preco = 10000.00;

        private int a = 10;
        public static void Executar() {
            // Acessar variavél 'a' dentro do método! a fazer
            // Console.WriteLine(a);

            // para acessar uma istancia sem ser que ela esteja estatica
            // precisamos fazer ruma rerferencia assim

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

            Console.WriteLine(desafio.preco);
        }
    }
}
