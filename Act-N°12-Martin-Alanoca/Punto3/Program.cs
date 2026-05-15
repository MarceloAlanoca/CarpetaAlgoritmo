using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Academy
    {
        /*
            3. Academia de Gastronomía: Recetario Dinámico
            Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
                Definir un vector para los nombres de los alumnos.
                Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato presentado.
                Métodos:
                    Cargar nombres y definir el tamaño de las filas según la cantidad de platos de cada alumno.
                    Cargar los puntajes de cada plato validando que estén entre 0 y 100.
                    Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
                    Calcular el puntaje promedio de cada alumno e informar si está "Aprobado" (promedio >= 70) o "Reprobado".
                    Determinar quién obtuvo el puntaje individual más alto en un solo plato (el valor máximo de la matriz).

        */
            private string[] alumnos;
            private int[][] platos;

        public void Inicio()
        {
            alumnos = new string[3];
            platos = new int[3][];
            int cantidad;
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                alumnos[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de platos del alumno");
                cantidad = int.Parse(Console.ReadLine());

                platos[i] = new int[cantidad];
            }

            Console.WriteLine();
        }

        public void CPuntajes()
        {
            int puntaje;

            for (int f = 0; f < platos.Length; f++)
            {
                for (int c = 0; c < platos[f].Length; c++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el puntaje del plato " + (c + 1) + " del alumno " + alumnos[f]);
                        puntaje = int.Parse(Console.ReadLine());

                    } while (puntaje < 0 || puntaje > 100);

                    platos[f][c] = puntaje;
                }
            }
            Console.WriteLine();
        }

        public void Mostrar()
        {
            for (int f = 0; f < platos.Length; f++)
            {
                Console.WriteLine("Alumno: " + alumnos[f]);

                for (int c = 0; c < platos[f].Length; c++)
                {
                    Console.Write(platos[f][c] + " - ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void Promedio()
        {
            int suma = 0;

            for (int f = 0; f < platos.Length; f++)
            {
                for (int c = 0; c < platos[f].Length; c++)
                {
                    suma = suma + platos[f][c];
                }

                double promedio = (double)suma / platos[f].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine(alumnos[f] + " aprobado con promedio: " + promedio);
                }
                else
                {
                    Console.WriteLine(alumnos[f] + " reprobado con promedio: " + promedio);
                }

                suma = 0;
            }

            Console.WriteLine();
        }

        public void MejorPlato()
        {
            int mayor = platos[0][0];
            string alumno = alumnos[0];

            for (int f = 0; f < platos.Length; f++)
            {
                for (int c = 0; c < platos[f].Length; c++)
                {
                    if (platos[f][c] > mayor)
                    {
                        mayor = platos[f][c];
                        alumno = alumnos[f];
                    }
                }
            }

            Console.WriteLine("El puntaje mas alto fue: " + mayor);
            Console.WriteLine("Pertenece al alumno: " + alumno);
        }

        public void MostrandoValores()
        {
            Inicio();
            CPuntajes();
            Mostrar();
            Promedio();
            MejorPlato();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Academy academy = new Academy();

            academy.MostrandoValores();
        }
    }
}
