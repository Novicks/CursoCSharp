﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleçoes
{
    internal class UsandoArray
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderso";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach ( var aluno in alunos ) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach ( var nota in notas ) {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio  += notas[1];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra); 
        }
    }
}
