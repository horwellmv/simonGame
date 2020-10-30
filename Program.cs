using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace simonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a SimonGame");
            Console.WriteLine("Nuestros elementos serán vocales.");

            //  ----------Definimos variables. --------------------------------------------------
            int index;
            int score = 0;

            List<string> listElements = new List<string>() { "a", "e", "i", "o", "u"}; // Lista Maquina
            List<string> listUser = new List<string>(); // Lista para los input del usuario. SOlo en caso de no lograrlo con COlas

            Random aleatory = new Random();

            Queue colaMachine = new Queue();
            Queue colaUser = new Queue();





            //---------------------Desarrollo del juego ---------------------------------------------------------

            do {
                score += 10; // Suma por cada ciclo 
                
                index = aleatory.Next(0, listElements.Count); // El cero toma el minimo de elementos, usarlos para dificultad 
                Console.WriteLine("Lo que random elije: {0}", index); // Solo para controlar si funcionaba el random 
                Console.WriteLine("Ronda {1}: {0}", listElements[index], score);


                colaMachine.Enqueue(listElements[index]); // Ingresa a la cola de la Maquina 

                Console.WriteLine("Elementos en la cola : {0}", colaMachine.Count);

                Console.Write("Ahora repite la secuencia... ");
                string entradaUser = Console.ReadLine();
                colaUser.Enqueue(entradaUser); // Ingresa a la cola de usuario


                
                

            } while (colaMachine == colaUser);
            
            Console.WriteLine("Eljuego ha terminado, tu puntaje es {0}", score); // Final del juego al fallar.
            PrintQueue(colaMachine); // COntrolamos que hubiera agregado elementos a la cola correctamente 
            PrintQueue(colaUser);




        }

        // ---------------- Esta funcion muestra en pantalla los elementos de la cola. -------
        public static void PrintQueue(Queue cola)
        {
            foreach (string element in cola)
                Console.Write("- Elemento random : {0}", element);
            Console.WriteLine();
        }

    }
}

