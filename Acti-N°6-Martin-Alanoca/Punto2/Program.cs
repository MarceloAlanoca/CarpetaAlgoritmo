using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
   

    internal class Cuadrado
    {
        private double lado;
        private String Linea;

        public  void iniciar()
        {
            Console.WriteLine("Ingrese el numero de lado: ");
            Linea = Console.ReadLine();
            lado = double.Parse(Linea);

        }

        public double CalcularPerimetro()
        {
            double Perimetro = lado * 4;
            return Perimetro;
        }

        public double CalcularSuperficie()
        {
            double Superficie = lado * lado;
            return Superficie;
        }

        public void MostrarValores()
        {
            Console.WriteLine($"el perimentro es: {CalcularPerimetro()}");
            Console.WriteLine($"la superficie es: {CalcularSuperficie()}");
            Console.WriteLine("el lado que ingresaste fue: " + lado);
        }

        static void Main(string[] args)
        {
            Cuadrado Cua = new Cuadrado();
            Cua.iniciar();
            Cua.CalcularPerimetro();
            Cua.CalcularSuperficie();
            Cua.MostrarValores();

            Console.ReadKey();

        }
    }
}
