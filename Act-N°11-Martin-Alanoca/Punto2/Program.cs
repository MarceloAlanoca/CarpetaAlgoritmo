using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        /*
            2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
                primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
                (crearla sin la intervención del operador)
                Realizar la carga por teclado e imprimir posteriormente.
         */

        private int[][] matriz;
        public void Incio()
        {
            matriz = new int[5][];
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                if (f % 2 == 0)
                {
                    matriz[f] = new int[1];
                }
                else
                {
                    matriz[f] = new int[2];
                }

                if (f == matriz.GetLength(0) - 1)
                {
                    matriz[f] = new int[5];
                }
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.WriteLine("Ingrese el valor de la celda : " + f + " - " + c);
                    string linea;
                    linea = Console.ReadLine();
                    matriz[f][c] = int.Parse(linea);
                }
            }
            Console.WriteLine(" --- ");
        }

        public void Imprimir()
        {
            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write(matriz[f][c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void MostrandoValores()
        {
            Incio();
            Imprimir();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program M = new Program();

            M.MostrandoValores();
        }
    }
}
