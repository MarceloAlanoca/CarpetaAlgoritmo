using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo//
            //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)//.


            //declaro la String linea tambien declaro las variables lado y parametro//
            string linea;
            int lado, perimetro;


            Console.Write("Ingrese el lado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            // calculo el perimetro calculando lado puestro anteriomente * 4//
            perimetro = lado * 4;

            //muetro el resultado de parametro a travez de consola//
            Console.Write("El perimetro es: ");
            Console.WriteLine(perimetro);

            Console.ReadKey();
        }
    }
}
