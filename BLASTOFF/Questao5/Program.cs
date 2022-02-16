using System;

// 5 - Faça um algoritmo para apresentar se dois números são múltiplos.

namespace Questao5
{
    class Program
    {
        static void Main(string[] args){
            double num1  = 3;
            double num2 = 11;
            
            if (num2%num1 == 0){
                Console.WriteLine("São multiplos!");
            } else {
                Console.WriteLine("Não são multiplos!");
            }
        }
    }
}