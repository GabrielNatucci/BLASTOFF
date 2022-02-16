using System;

namespace Questao
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Escreva uma palavra para verifica se ela é um palíndromo: ");
            string palavra = Console.ReadLine();
            int x = palavra.Length - 1;

            for (int i = 0; i < palavra.Length; i++){
                if (palavra[i] == palavra[x]){
                   x--; 
                }
            }

            if (x == -1){
                Console.WriteLine("\nA palavra é um palíndromo");
            } else {
                Console.WriteLine("\nA palavra não é um palíndromo");
            }
        }
    }
}