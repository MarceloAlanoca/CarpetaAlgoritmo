using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Empleado
    {
        //3. Confeccionar una clase que represente un empleado. Definir como atributos su
        //nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
        //sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        //(si el sueldo supera a 3000).
        private string nombre_empleado, linea;
        private int sueldo;

        public void IngresoDatos()
        {
            Console.WriteLine("Ingrese los dato:");

            nombre_empleado = Console.ReadLine();

            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
            
        }

        public string CalculoImpuestos()
        {
            if (sueldo > 3000)
            {
                return "El empleado debe pagar impuestos";
               
            }
            else
            {
                return "El empleado no paga impuesto";
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine("ingrese nombre de empleado: " + nombre_empleado);
            Console.WriteLine("ingrese el sueldo del empleado: " + sueldo);
            Console.WriteLine(CalculoImpuestos());
        }

        static void Main(string[] args)
        {
            Empleado Datos = new Empleado();
            Datos.IngresoDatos(); 
            Datos.CalculoImpuestos();
            Datos.MostrarDatos();

            Console.ReadKey();
        }
    }
}
