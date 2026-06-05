using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Matriz
    {
        /*
        Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.
        */
        private int[,] matriz;
        public void Inicio()
        {
            matriz = new int[2, 5];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Indique el valor de la posicion actual de la matriz");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[i, j] = int.Parse(linea);
                }

            }
        }

        public void Imprimir()
        {

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public void MostrandoValores()
        {
            Inicio();
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
