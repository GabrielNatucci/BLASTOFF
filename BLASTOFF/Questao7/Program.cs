using System;

// 7 - Dada uma lista de números A[1,2,3,…], faça um algoritmo que retorne uma lista somente
// com os números pares.

namespace Questao7
{
    class Program
    {
        static void Main(string[] args){
            int[] valores = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int x = 0;

            Console.WriteLine("Array completo:");
            for (int i = 0; i< valores.Length; i++){
                Console.WriteLine(valores[i]);
            }

            for (int i = 0; i < valores.Length; i++){
                if (valores[i]%2 == 0){
                    continue;
                } else {
                    valores = valores.Where((source, index) =>index != x).ToArray();
                }
                x++;
            }
            Console.WriteLine("\nArray com números pares:");
            for (int i = 0; i< valores.Length; i++){
                Console.WriteLine(valores[i]);
            }
        }
    }
}