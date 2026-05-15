using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    
    internal class Cine
    {
        /*
         2. Gestión de Complejo de Cine
            Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
            asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
                ● Definir una matriz irregular de 4 filas para representar los asientos.
                ● Métodos:
                    1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
                    intervención del operador).
                    2. Crear un método de Venta de Entradas que permita cargar la edad del
                    espectador en un asiento específico (fila y columna).
                    3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
                    en cada asiento.
                    4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
                    5. Informar cuál es el promedio de edad de los espectadores de todo el
                    complejo.
        */

        int[][] salas;

        public void CargarSalas()
        {
            salas = new int[4][];

            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
        }

        public void VentaEntradas()
        {
            Console.WriteLine("Cuantas entradas desea vender?");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el numero de sala desde la sala 1 hasta la 4");
                int sala = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el numero de asiento");
                int asiento = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la edad del espectador");
                int edad = int.Parse(Console.ReadLine());

                if (sala >= 1 && sala <= 4)
                {
                    if (asiento >= 1 && asiento <= salas[sala - 1].Length)
                    {
                        salas[sala - 1][asiento - 1] = edad;
                    }
                    else
                    {
                        Console.WriteLine("Asiento inexistente");
                    }
                }
                else
                {
                    Console.WriteLine("Sala inexistente");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
        }

        public void MostrarSalas()
        {
            for (int f = 0; f < salas.Length; f++)
            {
                Console.WriteLine("Sala numero: " + (f + 1));

                for (int c = 0; c < salas[f].Length; c++)
                {
                    Console.Write(salas[f][c] + " - ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void MenoresSala()
        {
            int menores = 0;

            for (int f = 0; f < salas.Length; f++)
            {
                for (int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] < 18 && salas[f][c] != 0)
                    {
                        menores++;
                    }
                }

                Console.WriteLine("La sala " + (f + 1) + " tiene " + menores + " menores");

                menores = 0;
            }

            Console.WriteLine();
        }

        public void PromedioCine()
        {
            double suma = 0;
            int cantidad = 0;

            for (int f = 0; f < salas.Length; f++)
            {
                for (int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] != 0)
                    {
                        suma = suma + salas[f][c];
                        cantidad++;
                    }
                }
            }

            double promedio = suma / cantidad;

            Console.WriteLine("El promedio de edad del complejo es: " + promedio);
        }

        public void Mostrando_Datos()
        {
            CargarSalas();
            VentaEntradas();
            MostrarSalas();
            MenoresSala();
            PromedioCine();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Cine Cine = new Cine();

            Cine.Mostrando_Datos();

            
        }
    }
}
