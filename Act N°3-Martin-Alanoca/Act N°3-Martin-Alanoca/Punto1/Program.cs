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
            //1. Realizar un programa que pida cargar una fecha cualquiera,//
            //luego verificar si dicha fecha corresponde a Navidad.//


            int dia, mes, año;
            String Linea;

            Console.WriteLine("Ingresa la fecha pls");
            Console.WriteLine("Dia : ");
            Linea = Console.ReadLine();
            dia = int.Parse(Linea);

            Console.WriteLine("Mes : ");
            Linea = Console.ReadLine();
            mes = int.Parse(Linea);

            Console.WriteLine("Año : ");
            Linea = Console.ReadLine();
            año = int.Parse(Linea);


            if (dia == 25 && mes == 12) {
                Console.WriteLine("Feliz Navidad");
            }
            else
            {
                Console.WriteLine("No es navidad es: " + dia + "/" + mes + ("/") + año);
            }

            Console.ReadKey();
        }
    }
}
