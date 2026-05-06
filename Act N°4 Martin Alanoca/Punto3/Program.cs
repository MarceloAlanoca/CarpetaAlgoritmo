using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.//

            int numeros, suma;
            String Linea;
            Cont_numeros = 0;

            do
            {

                Console.WriteLine("Inserte numeros para que se sumen: ");
                Linea = Console.ReadLine();
                numeros = int.Parse(Linea);

                if (numeros != 9999)
                {
                    suma = suma + numeros;
                }

            } while (numeros != 9999);

            Console.WriteLine("El valor total es: " + suma);

            if (suma > 0) 
            {
                Console.WriteLine("El valor total es mayor a 0");
            }
            else 
            {
                Console.WriteLine("El valor total es menor a 0");
            }
            if (suma == 0)
            {
                Console.WriteLine("El valor total es igual a 0");
            }

            Console.ReadKey();
        }
    }
}
