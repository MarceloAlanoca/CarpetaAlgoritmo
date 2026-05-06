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
            //3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10,//
            //imprimir en pantalla la leyenda "Todos los números son menores a diez"//

            double num1, num2, num3;
            String Linea;

            Console.WriteLine("Ingrese 3 numeros:");

            Console.WriteLine("Primer numero: ");
            Linea = Console.ReadLine();
            num1 = double.Parse(Linea);

            Console.WriteLine("Segundo numero: ");
            Linea = Console.ReadLine();
            num2 = double.Parse(Linea);

            Console.WriteLine("Tercer numero: ");
            Linea = Console.ReadLine();
            num3 = double.Parse(Linea);

            if (num1 < 10 && num2 < 10 && num3 < 10) {
                Console.WriteLine("Todos lo numero son menores a 10 \n" + num1 +"\n"+ num2 + "\n" + num3);    
            }
            else
            {
                Console.WriteLine("Uno de los  numero que ingresaste son mayores a 10 y son: \n" + num1 + "\n" + num2 + "\n" + num3);
            }
            Console.ReadLine();
        }
    }
}
