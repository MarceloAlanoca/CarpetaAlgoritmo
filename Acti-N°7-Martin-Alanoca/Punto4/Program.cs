using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Ordenado
    {
        //4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
        //ordenado de menor a mayor y de mayor a menor.

        private int[] Vector1;
        private float Esmayor = 0;
        private float Esmenor = 0;
        public void Iniciar()
        {
            Vector1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa un valor: ");
                string ingresado;
                ingresado = Console.ReadLine();
                Vector1[i] = int.Parse(ingresado);
            }
        }
        public void Validando()
        {
            
            for (int p = 0; p < Vector1.Length - 1; p++)
            {
                if (Vector1[p] <= Vector1[p + 1])
                {
                    Esmenor++;
                }
                if (Vector1[p] >= Vector1[p + 1])
                {
                    Esmayor++;
                }
            }
            
            
        }

        public void MostrarValores()
        {
            Validando();

            if (Esmenor == Vector1.Length - 1)
            {
                Console.WriteLine("El vector esta ordenado de menor a mayor");
            }
            else if (Esmayor == Vector1.Length - 1)
            {
                Console.WriteLine("El vector esta ordenado de mayor a menor");
            }
            else
            {
                Console.WriteLine("El vector no esta ordenado de ninguna forma");
            }
        }


        static void Main(string[] args)
        {
            Ordenado ORD = new Ordenado();
            ORD.Iniciar();
            ORD.MostrarValores(); 
            Console.ReadKey();

        }
    }
}
