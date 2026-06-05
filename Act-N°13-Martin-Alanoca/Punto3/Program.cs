using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
     3. Plantear una clase Club y otra clase Socio.
        La clase Socio debe tener los siguientes atributos privados: nombre y la
        antigüedad en el club (en años). En el constructor pedir la carga del nombre y
        su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
        Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
        antigüedad en el club.
     */
    class Socio
    {
        private string nombre;
        private int antiguedad;
        public Socio()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del socio");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la antiguedad del socio (en años)");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public int returnantiguedad()
        {
            return antiguedad;
        }

        public string returnnombre()
        {
            return nombre;
        }
    }
    internal class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void MayorSocio()
        {
            int mayor = 0;
            int antiguedad1 = socio1.returnantiguedad();
            int antiguedad2 = socio2.returnantiguedad();
            int antiguedad3 = socio3.returnantiguedad();
            if (antiguedad1 > mayor)
            {
                mayor = antiguedad1;
                nombre = socio1.returnnombre();
            }
            if (antiguedad2 > mayor)
            {
                mayor = antiguedad2;
                nombre = socio2.returnnombre();
            }
            if (antiguedad3 > mayor)
            {
                mayor = antiguedad3;
                nombre = socio3.returnnombre();
            }
            if (antiguedad1 == antiguedad2 && antiguedad2 == antiguedad3) 
            {
                Console.WriteLine("Todos los socios tienen la misma edad");
            }
            else
            {
                Console.WriteLine("El socio con mayor edad es : " + nombre);
            }
            
        }


        static void Main(string[] args)
        {
            Club C = new Club();
            C.MayorSocio();
            Console.ReadKey();
        }
    }
}
