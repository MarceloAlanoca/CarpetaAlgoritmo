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
            //2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
            //(No se ingresan valores por teclado)//

            int x, numero, cant_numeros;
            x = 0;
            numero = 25;
            cant_numeros = 0;

            Console.WriteLine("mostrando los 25 terminos: ");

            while (x <= numero) {
                cant_numeros = cant_numeros + 11;
                Console.Write(cant_numeros);
                Console.Write(" - ");
                x = x + 1;
                
            }

            Console.ReadKey();

        }
    }
}
