using System;

// 4 - Faça um algoritmo que converta a temperatura de C para F. Utilize a fórmula 

namespace Questao4
{
    class Program
    {
        static void Main(string[] args){
            double tempC = 19;

            // C = (5/9)*(F-32);
            // (C × 9/5) + 32 = F
            double tempF = tempC*1.8 + 32;
            Console.WriteLine(tempF);
        }
    }
}