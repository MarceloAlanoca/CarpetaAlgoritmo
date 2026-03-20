using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.//

            //declaro la variables de los numero que usare mas la suma y el promedio//
            int n1, n2, n3, n4;
            int suma, promedio;
            String Linea;

            Console.Write("ingrese el 1 numero: ");
            Linea = Console.ReadLine();
            n1 = int.Parse(Linea);

            Console.Write("Ingrese el 2 numero: ");
            Linea = Console.ReadLine();
            n2 = int.Parse(Linea);

            Console.Write("Ingrese el 3 numero: ");
            Linea = Console.ReadLine();
            n3 = int.Parse(Linea);

            Console.Write("Ingrese el 4 numero: ");
            Linea = Console.ReadLine();
            n4 = int.Parse(Linea);



            //hago la operacion suma sumando los numeros ingresados. despues saco el promedio dividiendo suma en 4//
            suma = n1 + n2 + n3 + n4;
            promedio = suma / 4;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}