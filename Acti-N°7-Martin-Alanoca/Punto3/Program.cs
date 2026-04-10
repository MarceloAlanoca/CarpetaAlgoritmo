using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Puntacion
    {
        //3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
        //un videojuego.El programa debe:
        // Mostrar la puntuación más alta y la más baja.
        // Calcular el promedio de puntuación.
        // Contar cuántas veces superó los 500 puntos.


        private int[] Elementos;


        private float promedio;

        public void Inicio()
        {
            Elementos = new int[6];
            int N = 1;
            Console.WriteLine("Ingrese los 6 valores de su puntacion:");
            String Linea;

            for (int P = 0; P < 6; P++) 
            {
                Console.Write("Dato N°" + N + ": ");
                Linea = Console.ReadLine();
                Elementos[P] = int.Parse(Linea);

                N = N + 1;
            }
        }

        public void CalculoPuntaje()
        {
            int max = Elementos.Max();
            int min = Elementos.Min();
            Console.WriteLine("el puntaje más alto es: " + max);
            Console.WriteLine("el puntaje más bajo es: " + min);
        }
        public void PromedioDeDatos()
        {
            float suma = 0;
            for (int t = 0; t < 6; t++)
            {
                suma = suma + (Elementos[t]);
            }
            promedio = suma / 6;
            Console.WriteLine("Promedio de puntaje: " + promedio);
        }
        public void Superior500()
        {
            int mayorde500 = 0;
            for (int S = 0; S < 6; S++)
            {
                if (Elementos[S] > 500)
                {
                    mayorde500++;
                }
            }

            Console.WriteLine("La cantidad de veces que superó los 500 puntos fue: " + mayorde500);
            
        }

        public void MostrarValores()
        {
            CalculoPuntaje();
            PromedioDeDatos();
            Superior500();
        }

        static void Main(string[] args)
        {
            Puntacion PE = new Puntacion();
            PE.Inicio();
            PE.MostrarValores();
            Console.ReadKey();
        }
    }
}
