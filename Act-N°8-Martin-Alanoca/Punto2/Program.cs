using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        //2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
        //algoritmo de ordenamiento alfabético.

        private String[] Pais;
        String Linea;

        public void Inicio()
        {
            Pais = new string[5];
            int N = 1;
            Console.WriteLine("Ingrese nombre 5 paises");
            for (int i = 0; i <5; i++) 
            {
                Console.Write("Pais N° " + N + ": ");
                Linea = Console.ReadLine();
                Pais[i] = Linea;

                N++;
            }
        }

        public void Ordenando()
        {
            Array.Sort(Pais);
            
        }
        
        public void MostrarValores()
        {
            Console.WriteLine("Ordenado alfabeticamente:");
            for (int i = 0;i < 5; i++)
            {
                
                Console.WriteLine(Pais[i]);
            }
        }

        static void Main(string[] args)
        {
            Program PA = new Program();
            PA.Inicio();
            PA.Ordenando();
            PA.MostrarValores();
            Console.ReadKey();

        }
    }
}
