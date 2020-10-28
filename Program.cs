using System;
using System.Collections.Generic;

namespace simonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a SimonGame");
            Console.WriteLine("Nuestros elementos serán vocales.");

            // Definimos variables. --------------------------------------------------
            int index;
            int score = 0;

            List<string> listElements = new List<string>() { "a", "e", "i", "o", "u"}; // Lista Maquina
            List<string> listUser = new List<string>(); // Lista para los input del usuario.

            Random aleatory = new Random();

            Queue <string> colaMachine = new Queue<string>();
            Queue<string> colaUser = new Queue<string>();





            //Desarrollo del juego ---------------------------------------------------------

            do {
                score += 1;
                
                index = aleatory.Next(0, listElements.Count); // El cero toma el minimo de elementos, usarlos para dificultad 
                //Console.WriteLine(index);
                Console.WriteLine("Ronda {1}: {0}", listElements[index], score);
                colaMachine.Enqueue(listElements[index]);
                PrintQueue(colaMachine);

                Console.WriteLine("Repite la secuencia... ");
                string entradaUser = Console.ReadLine();
                colaUser.Enqueue(entradaUser);
            } while (colaMachine == colaUser);

            Console.WriteLine("Eljuego ha terminado, tu puntaje es {0}", score);
            
               
            
            

        }


        public static void PrintQueue(Queue<String> cola)
        {
            foreach (string element in cola)
                Console.Write(" - {0}", element);
            Console.WriteLine();
        }




    }
}

