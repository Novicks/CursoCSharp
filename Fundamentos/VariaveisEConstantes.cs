using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar() {
            // area da circufenrencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;
            double area = PI * raio * raio;
            Console.WriteLine("Área é " + area);

            // Tipos de Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usados dos inteiros.
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor do Long " + menorValorLong);

            ulong populacaoMundial = 7_000_000_000;
            Console.WriteLine("A população Mundia é " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("O preço do comptudaro é " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usados dos reais.
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas é " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string texto = "Abacate é legal, pois tem um sabor diferenciado.";
            Console.WriteLine(texto);
        }
    }
}
