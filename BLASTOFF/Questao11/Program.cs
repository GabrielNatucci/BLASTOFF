using System;

// 11 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a
// intersecção das listas

namespace Questao
{
    class Program
    {
        static void Main(string[] args){
            int[] A = {1,2,3,4};
            int[] B = {1,2,5,8};
            int[] resul = {-1,-1,-1,-1};
            int x = 0;
            
            for (int i = 0; i < A.Length; i++){
                for (int y = 0; y < B.Length; y++){
                    if (A[i] == B[y]){
                        resul[i] = A[i];
                        x++;
                    }
                }
            }

            for (int i = 0; i < resul.Length; i++){
                if (resul[i] >= 0){
                    Console.WriteLine(resul[i]);
                }
            }

        }
    }
}