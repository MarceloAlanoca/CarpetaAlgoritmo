using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Paises
    {
        /*
         4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
        ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
        nuevamente.
         */
        private string[] Pais;
        private int[] Ciudadanos;

        public void Inicio()
        {
            String Linea;

            int N = 1;

            Pais = new String[5];
            Ciudadanos = new int[5];

            Console.WriteLine("Ingrese 5 pais: ");

            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Pais N° " + N + ": ");
                Linea = Console.ReadLine();
                Pais[i] = Linea;

                N = N + 1;
            }
            N = 1;
            Console.WriteLine("Ahora ingrese la cantidad de ciudadanos de los pais");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("digito N° " + N + ": ");
                Linea = Console.ReadLine();
                Ciudadanos[i] = int.Parse(Linea);

                N = N + 1;
            }

        }

        public void OrdAlf()
        {
            

            for (int i = 0; i < 5 ; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (Pais[i].CompareTo(Pais[j]) > 0)
                    {
                        String auxiliarP = Pais[i];
                        Pais[i] = Pais[j];
                        Pais[j] = auxiliarP;
                        int auxiliarH;
                        auxiliarH = Ciudadanos[i];
                        Ciudadanos[i] = Ciudadanos[j];
                        Ciudadanos[j] = auxiliarH;


                        
                    }
                }
            }
        }

        public void OrdNum()
        {
            for (int p = 0; p < 5; p++)
            {
                for (int e = p + 1; e < 5; e++)
                {
                    if (Ciudadanos[p] < Ciudadanos[e])
                    {
                        int auxiliarH = Ciudadanos[p];
                        Ciudadanos[p] = Ciudadanos[e];
                        Ciudadanos[e] = auxiliarH;
                        String auxiliarP = Pais[p];
                        Pais[p] = Pais[e];
                        Pais[e] = auxiliarP;
                    }
                }
            }
        }

        public void MostrandoValores()
        {
            OrdAlf();

            Console.WriteLine("Ordenado alfabetica");
            for (int i = 0; i < 5 ; i++) 
            {
                Console.WriteLine(Pais[i] + ": " + Ciudadanos[i] + " Habitantes");
                
               
            }
            OrdNum();

            Console.WriteLine("Ordenado numericamente");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Pais[i] + ": " + Ciudadanos[i] + " Habitantes");
                

            }

        }

        static void Main(string[] args)
        {
            Paises PP = new Paises();
            PP.Inicio();
            PP.MostrandoValores(); 
            Console.ReadKey();

            
        }
    }
}
