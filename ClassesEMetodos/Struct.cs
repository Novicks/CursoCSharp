using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Struct
    {
        interface Ponto {
            void MoverNaDiagonal(int delta);
        }

        struct Coordenada: Ponto { // atributos
            public int X;
            public int Y;

            public Coordenada(int x, int y) { // construtor
                X = x;
                Y = y;
            }

            public void MoverNaDiagonal(int delta) { // metedo
                X += delta;
                Y += delta;
            }

        }

        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Cordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
