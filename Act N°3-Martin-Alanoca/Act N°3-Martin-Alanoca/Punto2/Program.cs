using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //2.Se ingresan tres valores por teclado,//
            //si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.//


            int num1, num2, num3;
            int total;
            String Linea;

            Console.WriteLine("Ingrese los 3 digitos: ");

            Console.WriteLine("Primer Numero: ");
            Linea = Console.ReadLine();
            num1 = int.Parse(Linea);

            Console.WriteLine("Segundo Numero: ");
            Linea = Console.ReadLine();
            num2 = int.Parse(Linea);

            Console.WriteLine("Tercer Numero: ");
            Linea = Console.ReadLine();
            num3 = int.Parse(Linea);

            if (num1 == num2 && num2 == num3)
            {
                total = (num1 + num2) * num3;


                Console.WriteLine("El resultado de la operacion da: " + total);
            }
            else {
                Console.WriteLine("lo tres numeros no coinciden"); 

            }
            Console.ReadKey();
            
        }
    }
}
