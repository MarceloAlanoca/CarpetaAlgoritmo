using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Ordenanza
    {
        //3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
        //(el orden lo pueden elegir ustedes).

        private int[] Enteros;
        private int Num;

        public void Inicio()
        {
            String Linea;

            int N = 1;

            Console.WriteLine("ingrese el numero para ordenarlo: ");
            Linea = Console.ReadLine();
            Num = int.Parse(Linea);

            Enteros  = new int[Num];

            for (int i = 0; i < Num; i++) 
            { 
                Console.Write("Dato N°" + N + ": ");
                Linea = Console.ReadLine();
                Enteros[i] = int.Parse(Linea);

                N++;
            }
        }

        public void Ordenando() 
        {
            for (int i = 0; i < Num - 1; i++)
            {
                for (int j = i + 1; j < Num; j++)
                {
                    if (Enteros[i] < Enteros[j])
                    {
                        int aux = Enteros[i];
                        Enteros[i] = Enteros[j];
                        Enteros[j] = aux;
                    }
                }
            }
        }

        public void MostrarDatos() 
        {
            Ordenando();
            Console.WriteLine("Vector ordenado:");
            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine(Enteros[i]);
            }
        } 

        static void Main(string[] args)
        {
            Ordenanza OR = new Ordenanza();
            OR.Inicio();
            OR.MostrarDatos();
            Console.ReadKey();
        }
    }
}
