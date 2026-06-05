using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Matriz
    {
        /*3- Crear una matriz de n * m filas(cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma(mat[0][0]
        etc.)
        */

        private int[,] matriz;
        private int n, m;
        string linea;
        public void Inicio()
        { 
            Console.WriteLine("Ingrese cantidad de filas");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de columnas");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

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

        public void MostrandoVertices()
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.WriteLine("Vertices de la matriz:");

            Console.WriteLine("Arriba izquierda: " + matriz[0, 0]);
            Console.WriteLine("Arriba derecha: " + matriz[0, columnas - 1]);
            Console.WriteLine("Abajo izquierda: " + matriz[filas - 1, 0]);
            Console.WriteLine("Abajo derecha: " + matriz[filas - 1, columnas - 1]);
        }
        public void MostrandoFunciones()
        {
            Inicio();
            MostrandoVertices();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Matriz M = new Matriz();

            M.MostrandoFunciones();
        }
    }
}
