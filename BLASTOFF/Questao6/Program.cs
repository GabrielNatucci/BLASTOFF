using System;

// 6 - Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que
// calcule o tempo que durou a partida

namespace Questao6
{
    class Program
    {
        static void Main(string[] args){
            int A = 1;
            int minA = 00;
            int B = 3;
            int minB = 50;
            
            int dif = ( ((B*60)+minB) - ((A*60)+minA)  );
            int hora = 0;
            // Console.WriteLine(dif);

            while(dif>=60){
                dif -= 60;
                hora += 1;
            }

            Console.WriteLine("A partida teve uma duração de " + hora + " horas e " + dif + " minutos.");
        }
    }
}