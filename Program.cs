using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace SimonGame
{
    class Program
    {


        static void Main(string[] args)
        {
            //Variables que guardan la opción elegida por el usuario.
            string ingresar;
            int opcion = 0;
            bool salida = false;


            //Input del usuario.
            do
            {
                Console.WriteLine("¡Bienvenido a SimonGame!");
                Console.WriteLine("-");
                Console.WriteLine("¡Opciones de juego!");
                Console.WriteLine("-");
                Console.WriteLine("1 para jugar con números."); //Agregar la lista de nuemeros a jugar
                Console.WriteLine("2 para jugar con vocales.");

                Console.Write("Ingresar opción: ");
                ingresar = Console.ReadLine();
                if (ingresar == "1" || ingresar == "2")
                {
                    Console.Clear();
                    salida = true;
                    opcion = Convert.ToInt32(ingresar);
                }
                else
                {
                    Console.WriteLine("¡Ingresar alguno de los valores indicados SIN ESPACIOS!");
                    Console.Clear();
                }
            } while (salida == false);

            switch (opcion)
            {
                case 1:
                    JuegaConVocales();
                    break;
                case 2:
                    JuegaConVocales();
                    break;

            } // Fin del switch - case.


            Console.ReadKey();

        }
          
        //Comienzo de la función JuegaConVocales();
        // -------- Metod Contiene la logica del juego y sus variables.

        static void JuegaConVocales(int dificultad = 0)
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

            // Iniciamos el juego y damos bienvenida... eli dificult

            Console.WriteLine("Juguemos con Simon");
            Console.WriteLine("Elige la cantidad de vocales con las que quieres jugar");
            Console.Write("0 = Mdo Dios, 1 = Mdo Leyenda, 2 = Mdo Normal, 3 = Mdo Babys ");
            int dificil = int.Parse(Console.ReadLine());
            Console.WriteLine("Recuerda, separa tus vocales con la barra espaciadora");
            Console.WriteLine("Muy bien, Vamos a jugar.");
            while (acierto != false)
            {


                Console.WriteLine("Excelente! ");
                Console.Clear();
                score += 150; // aumento de puntaje por cada acierto, 150 puntos por ronda
                indice += 1;

                int azar = aleatory.Next(dificil, elementos.Count); // Aqui elige la dificultad
                palabraMaquina.Add(elementos[azar]); palabraMaquinaTemporal.Add(elementos[azar]);

                PrintList(palabraMaquinaTemporal);
                Console.Write($"Ahora tus vocales: ");
                Console.Write($"Debes ingresar {indice + 1} vocales: ");
                palabraMaquinaTemporal.Clear(); palabraUsuario.Clear();

                String entradas = Console.ReadLine();
                String[] entradaToLista = entradas.Split();
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
        //Fin de la función JuegaconVocales();

    } //Fin de la clase Program.
}