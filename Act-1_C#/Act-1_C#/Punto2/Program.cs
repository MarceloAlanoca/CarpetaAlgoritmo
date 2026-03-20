using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Escribir un programa en el cual se ingresen cuatro números, calcular e//
            //informar la suma de los dos primeros y el producto del tercero y el cuarto.//


            //declaro la variable y pongo un string para luego permitirme poner cada numero
            int n1, n2, n3, n4;
            String Linea;

            Console.Write("Ingrese el 1 numero: ");
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

            //muestrp el resultado de suma y producto y hago el caculo de sumar o multiplicar//
            Console.WriteLine("Suma: " + (n1 + n2));
            Console.WriteLine("Producto: " + (n3 * n4));
        }
    }
}
