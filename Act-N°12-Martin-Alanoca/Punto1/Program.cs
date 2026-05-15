using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Sistema de Logística: Envíos por Sucursal
       Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
       cantidad diferente de paquetes por día dependiendo de su demanda.
           ● Definir un vector de tipo string para los nombres de las 3 sucursales.
           ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
           represente el peso (en kg) de cada paquete enviado.
           ● Métodos:
               1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
               paquetes se enviaron hoy para definir el tamaño de su fila.
               2. Cargar el peso de cada paquete.
               3. Imprimir el peso de todos los paquetes organizados por sucursal.
               4. Calcular e informar el peso total despachado por cada sucursal.
               5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
               pertenece.
    */
    internal class SucursalMayorista
    {
        private string[] sucursales;
        private int[][] paquetes;

        public void Incio()
        {
            sucursales = new string[3];
            paquetes = new int[3][];

            Console.WriteLine("Ingrese los nombre de las sucursal");

            for (int i = 0; i < sucursales.Length; i++)
            {

                Console.WriteLine("Ingrese el nombre de la sucursal numero " + (i + 1));
                string linea = Console.ReadLine();
                sucursales[i] = linea;
                
                Console.WriteLine("Ingrese la cantidad de paquetes que tiene la sucursal: " + sucursales[i]);
                string cantidad = Console.ReadLine();
                paquetes[i] = new int[int.Parse(cantidad)];
            }
            Console.WriteLine();
        }

        public void RegistroPeso()
        {
            Console.WriteLine("ingrese el peso de los paquetes");
            for (int f = 0; f < sucursales.Length; f++)
            {
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    Console.WriteLine("Ingrese el peso(KG) del paquete numero: " + (1 + c) + ", de la sucursal: " + sucursales[f]);
                    string peso = Console.ReadLine();
                    paquetes[f][c] = int.Parse(peso);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public void PesoPorSucursal()
        {
            for (int f = 0; f < sucursales.Length; f++)
            {
                Console.WriteLine("Los pesos de los paquetes de la sucursal: " + sucursales[f] + " son: ");
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    Console.Write(paquetes[f][c] + "KG - ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void TotalSucursal()
        {
            int total = 0;

            for (int f = 0; f < sucursales.Length; f++)
            {
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    total = total + paquetes[f][c];
                }
                Console.WriteLine("El total de peso(KG) de la sucursal: " + sucursales[f] + " es: " + total);
                total = 0;
            }
        }

        public void CalculototalPeso()
        {
            int mayor = paquetes[0][0];
            string sucursal = sucursales[0];

            for (int f = 0; f < sucursales.Length; f++)
            {
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    if (paquetes[f][c] > mayor)
                    {
                        mayor = paquetes[f][c];
                        sucursal = sucursales[f];
                    }
                }
            }
            Console.WriteLine("El paquete mas pesado es de: " + mayor + "KG, de la sucursal: " + sucursal);
        }

        public void Sucural()
        {
            Incio();
            RegistroPeso();
            PesoPorSucursal();
            TotalSucursal();
            CalculototalPeso();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            SucursalMayorista SM = new SucursalMayorista();

            SM.Sucural();
        }
    }
}
