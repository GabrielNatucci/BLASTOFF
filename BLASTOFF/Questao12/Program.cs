using System;

// 12 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a
// concatenação das listas

namespace Questao12
{
    class Program
    {
        static void Main(string[] args){
            int[] A = {1,2,3,4};
            int[] B = {1,2,5,8};
            int[] resul;

            resul = new int[A.Length + B.Length];
            A.CopyTo(resul, 0);
            B.CopyTo(resul, A.Length);

            for (int i = 0; i < resul.Length; i++){
                Console.WriteLine(resul[i]);
            }
        }
    }
}