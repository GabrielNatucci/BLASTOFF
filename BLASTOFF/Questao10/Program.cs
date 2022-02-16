using System;

// 10 - Faça um algoritmo que receba um número e retorne o Fatorial desse número.

namespace Questao10
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Escreva um número para o cálculo de fatorial (maior que zero): ");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 2;
            int fatorial = 1;

            while (num<=0){
                Console.WriteLine("Escreva um número para o cálculo de fatorial (maior que zero): ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 2; i <= num; i++){
                fatorial = fatorial*x;
                x++;
            }
            
            Console.WriteLine("\nO fatorial é igual a:\n" + fatorial + "\n");
        }
    }
}