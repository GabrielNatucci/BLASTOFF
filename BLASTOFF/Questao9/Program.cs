using System;

// 9 - Faça um algoritmo que receba um número e retorne a tabuada desse número.

namespace Questao9
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Escreva um número para obter a tabuáda dele: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++){
                Console.WriteLine(num + " * " + (i+1) + " = " + num*(i+1));
            }
            Console.WriteLine("\n");
        }
    }
}