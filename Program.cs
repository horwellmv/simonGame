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


            Console.WriteLine("Juguemos con Simon");
            Console.WriteLine("Elige la cantidad de vocales con las que quieres jugar");
            Console.Write("0 = Mdo Dios, 1 = Mdo Leyenda, 2 = Mdo Normal, 3 = Mdo Babys ");
            int dificil = int.Parse(Console.ReadLine());
            Vocales(dificil);

        }


        // -------- Metod Contiene la logica del juego y sus variables.

        static void Vocales(int dificultad = 0)
        {
            // -----  Aqui estan definidas nuestras listas, enteros, arrays, boleanos y contadores

            List<String> elementos = new List<string>() { "a", "e", "i", "o", "u" }; // Lista de elementos a jugar disponibles
            List<String> palabraMaquina = new List<String>();
            List<String> palabraMaquinaTemporal = new List<String>();
            List<String> palabraUsuario = new List<String>();
            Random aleatory = new Random();
            Boolean acierto = true;
            float score = 0;
            int indice = -1;


            Console.WriteLine("Recuerda, separa tus vocales con la barra espaciadora");
            Console.WriteLine("Muy bien, Vamos a jugar.");
            while (acierto != false) {


                Console.WriteLine("Excelente! ");
                Console.Clear();
                score += 150 ; // aumento de puntaje por cada acierto, 150 puntos por ronda
                indice += 1;

                int azar = aleatory.Next(dificultad, elementos.Count);
                palabraMaquina.Add(elementos[azar]); palabraMaquinaTemporal.Add(elementos[azar]);

                PrintList(palabraMaquinaTemporal);
                Console.Write($"Ahora tus vocales: ");
                palabraMaquinaTemporal.Clear(); palabraUsuario.Clear();

                String entradas = Console.ReadLine();
                String[] entradaToLista = entradas.Split(" ");
                foreach (String entrada in entradaToLista) // agregamos las entradas de usuario como lista
                {
                    palabraUsuario.Add(entrada);
                }


                foreach (String Elemento in palabraMaquina)
                {
                    
                    if (palabraMaquina[indice] == palabraUsuario[indice])
                    {
                        acierto = true; // Si son iguaales los index de cada lista mantiene el While
                        
                    }
                    else
                    {
                        acierto = false; // Sale del While
                        Console.WriteLine($"Perdiste.. tu puntaje final es = {score} puntos");
                        Console.WriteLine("Gracias por jugar. ");
                        break;
                    }
                }

            } 

        }



        // ---------------- Esta funcion muestra en pantalla los elementos de la lista. -------
        public static void PrintList(List<string> lista)
        {
            foreach (string element in lista)
                Console.WriteLine("Simon dice : {0}", element);             

        }

   


    }

}

