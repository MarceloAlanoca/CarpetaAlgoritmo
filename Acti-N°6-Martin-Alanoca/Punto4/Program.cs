using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Calculadora
    {
        //4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
        //calcular su suma, resta, multiplicación y división, cada una en un método,
        //imprimir dichos resultados.
        private int num1, num2;
        string Linea;

        public void Inicio()
        {
            Console.WriteLine("Ingrese 2 digitos");
            Console.Write("1° digito: ");
            Linea = Console.ReadLine();
            num1 = int.Parse(Linea);

            Console.Write("2° digito: ");
            Linea = Console.ReadLine();
            num2 = int.Parse(Linea);
        }

        public int CalculoSuma() 
        {
            int Suma = num1 + num2;
            return Suma;
        }
        public int CalculoResta() 
        {
            int Resta = num1 - num2;
            return Resta;
        }
        public int CalculoMultiplicar() 
        { 
            int Multiplicacion = num1 * num2;
            return Multiplicacion;
        }
        public int CalculoDividir() 
        { 
            int Dividir = num1 / num2;
            return Dividir;
        }

        public void MostrarValores()
        {   

            Console.Write($"La suma de los valores es: {CalculoSuma()}" + "\n");
            Console.Write($"La resta de los valores es: {CalculoResta()}" + "\n");
            Console.Write($"La multiplicion de los valores es: {CalculoMultiplicar()}" + "\n");
            Console.Write($"La division de los valores es: {CalculoDividir()}" + "\n");
        }

        static void Main(string[] args)
        {
            Calculadora Calculo = new Calculadora();
            Calculo.Inicio();
            Calculo.CalculoSuma();
            Calculo.CalculoResta();
            Calculo.CalculoMultiplicar();
            Calculo.CalculoDividir();
            Calculo.MostrarValores();

            Console.ReadKey();
        }
    }
}
