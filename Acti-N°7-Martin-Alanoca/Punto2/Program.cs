using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Valores
    {
        //2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        //elementos.Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        //tercer vector del mismo tamaño.Sumar componente a componente.


        private int[] Vector1;
        private int[] Vector2;
        private int[] total;
        

        public void Inicio()
        {
            int N = 1;

            Vector1 = new int[4];
            Vector2 = new int[4];

            Console.WriteLine("Ingrese 4 digitos en los 2 vectores");
            string Linea;
            
            Console.WriteLine("Vector N°1:");
            for (int v = 0; v < 4; v++) 
            {
                Console.Write("Dato N°" + N + ": ");
                Linea = Console.ReadLine();
                Vector1[v] = int.Parse(Linea);

                N = N + 1;
            }
            N = 1;
            Console.WriteLine("Vector N°2:");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Dato N°" + N + ": ");
                Linea = Console.ReadLine();
                Vector2[f] = int.Parse(Linea);

                N = N + 1;
            }


        }

        public void Suma()
        {
            total = new int[4];
            for (int t = 0; t < 4; t++) 
            {
                int SumaT = 0;

                SumaT = Vector1[t] + Vector2[t];

                total[t] = SumaT + total[t];
                Console.WriteLine(total[t]);
            }

        }

        public void MostrarDatos()
        {
            
        }



        static void Main(string[] args)
        {
            Valores Vec = new Valores();
            Vec.Inicio();
            Vec.Suma();
            Console.ReadKey();
        }
    }
}
