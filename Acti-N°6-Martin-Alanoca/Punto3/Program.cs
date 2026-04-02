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
