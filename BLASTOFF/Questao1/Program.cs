
using System;

// 1- Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.

namespace Questao1
{
    class Program
    {
        static void Main(string[] args){
            float I = 20;
            float J = 25;
            float K = 15;
            float X = 25;
            float Y = 17;
            double media = ((I+J+K+X+Y)/(5));
            media = Math.Round(media,2);
            Console.WriteLine(media);
        }
    }
}
