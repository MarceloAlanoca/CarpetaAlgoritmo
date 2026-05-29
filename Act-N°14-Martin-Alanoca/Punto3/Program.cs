using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Atleta
    {
        private string NombreAtleta;
        private float MarcarRecord;

        public Atleta()
        {
            string linea;
            Console.WriteLine("Ingrse la informacion de los atletax");
            Console.WriteLine();
            Console.WriteLine("Nombre del atleta:");
            linea = Console.ReadLine();
            NombreAtleta = linea;

            Console.WriteLine("ingrese su TiempoSegundos:");
            linea = Console.ReadLine();
            NombreAtleta = linea;


        }
    }
    internal class Carrera
    {
        static void Main(string[] args)
        {
        }
    }
}
