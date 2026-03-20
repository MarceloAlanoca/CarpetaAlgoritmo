using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros)//
            //de una persona, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo//
            //el peso entre el cuadrado de la altura).//


            //Declaro la variables peso, altura, imc
            double peso, altura, imc;

            //permito que se ingresen los datos de peso, altura que me serviran para mas tarde//
            Console.WriteLine("Peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            //hago el calculo para calcular la masa corporal para luego mostrarla en la consola
            imc = peso / (altura * altura);

            Console.WriteLine("IMC: " + imc);
        }
    }
}
