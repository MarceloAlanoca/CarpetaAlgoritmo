using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        /*
            Una empresa registra los nombres de sus 5 vendedores y el total de ventas
            realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
            vectores paralelos, ordenar los datos de mayor a menor según las ventas,
            imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
            el que menos vendió de los 5 empleados.
        */
        private string[] Vendedores;
        private int[] CVentas;
        public void Inicio()
        {
            Vendedores = new string[5];
            CVentas = new int[5];
            for (int i = 0; i < Vendedores.Length; i++)
            {
                Console.WriteLine("Ingresa un vendedor: ");
                Vendedores[i] = Console.ReadLine();
                Console.WriteLine("Ingresa su total de ventas realizadas: ");
                string valor;
                valor = Console.ReadLine();
                CVentas[i] = int.Parse(valor);
            }
        }
        public void Ordenar()
        {
            for (int i = 0; i < Vendedores.Length - 1; i++)
            {
                for (int j = 0; j < Vendedores.Length - 1 - i; j++)
                {
                    if (CVentas[j] < CVentas[j + 1])
                    {
                        int aux = CVentas[j];
                        CVentas[j] = CVentas[j + 1];
                        CVentas[j + 1] = aux;

                        string aux2 = Vendedores[j];
                        Vendedores[j] = Vendedores[j + 1];
                        Vendedores[j + 1] = aux2;
                    }
                }
            }
            int menos_ventas = CVentas[CVentas.Length - 1];
            string v_menos = Vendedores[Vendedores.Length - 1];

            Console.WriteLine("Vendedores ordenados en cantidad de ventas mayor a menor: ");
            for (int i = 0; i < Vendedores.Length; i++)
            {
                Console.Write(Vendedores[i] + " con el monto de venta de: " + CVentas[i]);
                Console.WriteLine();
            }
            Console.WriteLine("Vendedor que vendio menos: " + v_menos + " con la cantidad de: " + menos_ventas);

            
        }
        public void MostrandoValores()
        {
            Inicio();
            Ordenar();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MostrandoValores();
        }
    }
        
    
}
