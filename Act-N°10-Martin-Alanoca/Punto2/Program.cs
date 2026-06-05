using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Matriz
    {
        private int[,] matriz;
        string linea;
        private int f, c;
        /*
         2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.
         */
        public void Inicio()
        {
           
            Console.WriteLine("Ingrese cantidad de filas");
            f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de columnas");
            c = int.Parse(Console.ReadLine());

            matriz = new int[f, c];

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine($"Valor para [{f},{c}]:");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Intercambio()
        {
            int columnas = matriz.GetLength(1);

            for (int c = 0; c < columnas; c++)
            {
                int aux = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = aux;
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public void MostrandoValores() 
        {
            Inicio();
            Intercambio();
            Imprimir();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Matriz M = new Matriz();
            
            M.MostrandoValores();
            
        }
    }

}
