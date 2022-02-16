using System;

// 2- Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo
// médio.

namespace Questao2
{
    class Program
    {
        static void Main(string[] args){
            double A = 50;
            double B = 16;
            double consumo = A/B;
            Console.WriteLine("O seu carro consumiu " +  consumo + " kilometros por litro gasto");
        }
    }
}