using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Persona
    {
        protected String nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void ImprimirPersona()
        { 
            Console.WriteLine("Nombre de la persona " + nombre + " y edad: " + edad);
        }
    }
    class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public void ImprimirEmpleado()
        {
            Console.WriteLine("Nombre del empleado: " + nombre + " edad del empleado: " + edad + " y la cantidad que es: " + sueldo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Pablito";
            persona.Edad = 10;
            Console.WriteLine("---Caragando informacion de la persona---");
            persona.ImprimirPersona();
            Console.WriteLine();
            Empleado empleado = new Empleado();
            empleado.Nombre = "Alejandra";
            empleado.Edad = 17;
            empleado.Sueldo = 100;
            Console.WriteLine("---Cargando informacion del empleado---");
            empleado.ImprimirEmpleado();

            Console.ReadKey();

        }
    }
}
