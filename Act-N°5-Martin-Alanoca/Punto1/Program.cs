using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            //39.

            int bucle, valor,multi;
            String Linea;
            bucle = 13;
            multi = 0;

            Console.WriteLine("Ingrese un valor del 1 al 10");
            Linea = Console.ReadLine();
            valor = int.Parse(Linea);

            Console.WriteLine("motrando la tabla de multiplicacion de numero elejido solo hasta 13 terminos");

            for (int i = 0; i < bucle; i++) {

                

                multi = valor + multi;
                Console.WriteLine(multi);

            }
            Console.ReadKey();
        }
    }
}
