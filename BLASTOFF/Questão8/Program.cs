using System;

// 8 - Faça um algoritmo que receba um número e retorne se o número é primo ou não.

namespace teste
{
    class Questao8
    {
        static void Main(string[] args){

            Console.Write("Digite o valor para ver se é primo ou não: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int div = 0;

            for (int i = 0; x <= valor; i++){
                if (valor % x == 0 && x > 1){
                    div = x;
                    break;
                }
                x++;
            }
            if (div == valor){
                Console.WriteLine("\nO número "+ valor + " é primo.\n");
            } else {
                Console.WriteLine("\nO número "+ valor + " não é primo.\n");
            }
        }
    }
}