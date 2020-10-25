using System;
using System.Collections;

namespace simonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a SimonGame");
            Console.WriteLine("Nuestros elementos serán vocales.");

            // Definimos variables. 
            int index;
            string[] listElements = new string[] { "a", "e", "i", "o", "u" }; // Elementos para el juego
            string[] listUser = new string[] { }; // Lista para los input del usuario.
            Random aleatory = new Random();

            Console.WriteLine(listElements.Length);



            index = aleatory.Next(0, listElements.Length);

            Console.WriteLine("Vocal es: {0}", listElements[index]);

            Queue colaMachine = new Queue();
            colaMachine.Enqueue(listElements[index]);
            index = aleatory.Next(0, listElements.Length);
            colaMachine.Enqueue(listElements[index]);
            PrintQueue(colaMachine);






        }


        public static void PrintQueue(IEnumerable myQueue)
        {
            foreach (Object element in myQueue)
                Console.Write(" - {0}", element);
            Console.WriteLine();
        }
    }
}
