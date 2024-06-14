using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
        }

        public static void Executar() {
            Formatar(mes: 1, dia: 6, ano: 1996);

            int valorDia = 0;
            int valorMes = 0;
            int valorAno = 0;
            Console.WriteLine("Qual a data?");
            Console.Write("Dia: ", valorDia);
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out valorDia);

            Console.Write("Mês: ", valorMes);
            entrada = Console.ReadLine();
            int.TryParse(entrada, out valorMes);

            Console.Write("Ano: ", valorAno );
            entrada = Console.ReadLine();
            int.TryParse(entrada, out valorAno);

            Console.Write("Seu data é: ");
            Formatar(dia: valorDia, mes: valorMes, ano: valorAno);



        }
    }
}
