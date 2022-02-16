using System;

// 3 - Dados três números (a, b, c), faça um algoritmo para mostrar o menor número.

namespace Questao3
{
    class Program
    {
        static void Main(string[] args){
            int A = 30;
            int B = 15;
            int C = 20;
            int[] valores = {A,B,C};

            Console.WriteLine(valores.Min());
        }
    }
}