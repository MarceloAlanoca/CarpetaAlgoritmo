using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.//
            //Mostrar lo que debe abonar el comprador.//

            //declaro la variables precio,total como double porque son numeros decimales mas declaro la cantidad//
            double precio;
            int cantidad;
            double total;


            //ingreso los valores de precio y la cantidad de los dichos//
            Console.WriteLine("Precio:");
            precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cantidad:");
            cantidad = Convert.ToInt32(Console.ReadLine());


            //hago el calculo para total multiplicando preio ^ cantidad//
            total = precio * cantidad;
            
            //hago una console log para mostrar cuanto tiene que pagar//
            Console.WriteLine("Total a pagar: " + total);
        }
    }
}
