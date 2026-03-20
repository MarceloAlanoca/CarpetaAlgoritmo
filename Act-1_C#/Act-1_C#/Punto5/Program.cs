using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo//
            //(La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).//

            //Declaro la variables radio, area, circunferencia con double porque hay numero decimales
            double radio;
            double area, circunferencia;


            //hago un writeLine para ingresar el numero de radio que tengo//
            Console.WriteLine("Ingrese radio:");
            radio = Convert.ToDouble(Console.ReadLine());

            //calculo la circunferencia haciendo 2 * PI * radio//
            circunferencia = 2 * Math.PI * radio;

            //calculo el area PI * radio al cuadrado//
            area = Math.PI * (radio * radio);

            Console.WriteLine("Circunferencia: " + circunferencia);
            Console.WriteLine("Area: " + area);
        }
    }
}
