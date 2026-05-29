using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto2
{
    class Calculos
    {
        private int num1;
        private int num2;
        private int total;
        
        public Calculos(int a, int b)
        {
            num1 = a;
            num2 = b;
            total = 0;
        }

        public void sumar()
        {
            total = num1 + num2;
        }

        public void restar()
        {
            total = num1 - num2;
        }

        public void multiplicar()
        {
            total = num1 * num2;
        }

        public void dividir()
        {
            total = num1 / num2;
        }

        public int DevolverTotal() 
        { 
            return total;
        }

    }

    internal class Calculadora
    {
        private Calculos cuenta1;
        public Calculadora()
        {
            cuenta1 = new Calculos(9, 3);
        }

        public void MostrandoCalculos()
        {
            cuenta1.sumar();
            Console.WriteLine($"la operacion suma es: {cuenta1.DevolverTotal()}");
            cuenta1.restar();
            Console.WriteLine($"la operacion resta es: {cuenta1.DevolverTotal()}");
            cuenta1.dividir();
            Console.WriteLine($"la operacion dividir es: {cuenta1.DevolverTotal()}");
            cuenta1.multiplicar();
            Console.WriteLine($"la operacion multiplicar es: {cuenta1.DevolverTotal()}");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Calculadora  Cal= new Calculadora();
            Cal.MostrandoCalculos();
        }
    }
}
