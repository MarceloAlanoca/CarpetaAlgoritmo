using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        private string[] empleados;
        private int[][] faltas;

        public void Carga()
        {
            empleados = new string[3];
            faltas = new int[3][];

            for (int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                empleados[f] = Console.ReadLine();

                Console.WriteLine("Cuantos dias falto " + empleados[f] + "?");
                string linea;
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea);

                faltas[f] = new int[cantidad];

                for (int c = 0; c < faltas[f].Length; c++)
                {
                    Console.WriteLine("Ingrese el dia que falto");
                    linea = Console.ReadLine();
                    faltas[f][c] = int.Parse(linea);
                }
            }

            Console.WriteLine();
        }

        public void Imprimir()
        {
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine("Empleado: " + empleados[f]);

                Console.WriteLine("Dias que falto:");

                for (int c = 0; c < faltas[f].Length; c++)
                {
                    Console.WriteLine(" - " + faltas[f][c]);
                }

                Console.WriteLine("Cantidad de inasistencias: " + faltas[f].Length);

                Console.WriteLine();
            }
        }

        public void MenosFaltas()
        {
            int menor = faltas[0].Length;
            string nombre = empleados[0];

            for (int f = 0; f < empleados.Length; f++)
            {
                if (faltas[f].Length < menor)
                {
                    menor = faltas[f].Length;
                    nombre = empleados[f];
                }
            }

            Console.WriteLine("El empleado que menos falto es: " + nombre);
            Console.WriteLine("Cantidad de faltas: " + menor);
        }
        static void Main(string[] args)
        {
            Program aa = new Program();

            aa.Carga();
            aa.Imprimir();
            aa.MenosFaltas();

            Console.ReadKey();
        }

    }
}
