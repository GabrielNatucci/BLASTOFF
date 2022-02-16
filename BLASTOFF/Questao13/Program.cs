using System;

// 13 - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os
// valores dessa matriz.

namespace Questao13
{
    class Program
    {
        static void Main(string[] args){
            int[,] matriz = new int[4,4];

            for (int j = 0; j < 4; j++){ // preenchendo a matriz com varios valores
                for (int i = 0; i < 4; i++){
                    Console.Write("\nDigte um valor para a linha " + i + " e para coluna " + j + " da matriz: ");
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }   
            }

            for (int j = 0; j < 4; j++){
                Console.Write("\n");
                for (int i = 0; i < 4; i++){
                    Console.Write(matriz[i,j] + " ");
                }   
            }
            Console.WriteLine("\n");
        }
    }
}