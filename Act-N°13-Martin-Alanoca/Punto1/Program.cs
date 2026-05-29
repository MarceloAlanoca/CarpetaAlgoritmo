using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Empleado
    {
        private int SueldoEmpleado;
        private string NombreEmpleado;
        public Empleado()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del empleado");
            NombreEmpleado = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            linea = Console.ReadLine();
            SueldoEmpleado = int.Parse(linea);
        }

        public void CalImp()
                {
                    if (SueldoEmpleado > 3000)
                    {
                        Console.WriteLine("El empleado tiene que pagar impuestos");
                    }
                }

        public void Imprimir()
        {
            Console.WriteLine("El empleado " + NombreEmpleado + " con su sueldo de " + SueldoEmpleado);
        }

        public void DatosTotales()
        {
            Imprimir();
            CalImp();
            Console.ReadKey();
        }
        


        static void Main(string[] args)
        {
            Empleado E = new Empleado();
            E.DatosTotales();
        }
    }
}
