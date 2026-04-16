using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        //1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
        //del vector.

        private float[] Vector1;
        private float menor;
        private int Num;
        private int ContM = 0;

        public void Inicio()
        {
            int N = 1;
            
            

            String Linea;
            Console.Write("ingrese la cantidad de numeros que quieres ordenar: ");
            Linea = Console.ReadLine();
            Num = int.Parse(Linea); 
            Vector1 = new float[Num];
            for (int i = 0; i < Num; i++) 
            {
                Console.Write("Dato N° " + N + ": ");
                Linea = Console.ReadLine();
                Vector1[i] = int.Parse(Linea);


                N = N + 1;
            }
        }

        public void Validando()
        {

            menor = Vector1[0];
            for (int i = 0; i < Num ; i++)
            {
                if (Vector1[i] < menor) 
                {
                    menor = Vector1[i];
                    
                }
                
            }

            for (int i = 0; i < Num; i++) 
            {
                if (Vector1[i] == menor)
                {
                    ContM++;
                }
            }
            

            
        }

        public void MostrarValores()
        {
            Validando();
            Console.WriteLine("El numero menor es: " + menor);
            if (ContM > 0)
            {
                Console.WriteLine("Hay numeros donde se repite " + ContM);
            }
            else
            {
                Console.WriteLine("No hay numeros que se repitan");
            }
        }

        static void Main(string[] args)
        {
            Program PR = new Program();
            PR.Inicio();
            PR.MostrarValores();
            Console.ReadKey();

        }
    }
}
