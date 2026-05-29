using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Pasajeros
    {
        private String Nombre;
        private int DNI;
        private float EquipajeKG;

        public Pasajeros()
        {
            String linea;

                        
            Console.Write("ingrese el nombre del pasajero: ");
            linea = Console.ReadLine();
            Nombre = linea;

            Console.Write("--> Ingrese el Dni del pasajero: ");
            linea = Console.ReadLine();
            DNI = int.Parse(linea);
            
            Console.Write("--> ingrese el peso de equipaje(KG): ");
            linea = Console.ReadLine();
            EquipajeKG = float.Parse(linea);
            Console.WriteLine();
        }

        public string ReturnNombre()
        {
            return Nombre;
        }
        public int ReturnDni()
        {
            return DNI;
        }
        public float ReturnEquipaje()
        {
            return EquipajeKG;
        }
    }
    internal class Vuelo
    {
        private Pasajeros[] persona;
        public Vuelo()
        {

            persona = new Pasajeros[4];
            Console.WriteLine("--- Ingrese los datos del pasajero ---");

            for (int i = 0; i < persona.Length; i++)
            {
                persona[i] = new Pasajeros();
            }
        }
        public void Listado()
        {
            Console.WriteLine("Informacion de los pasajeros cargado: ");
            Console.WriteLine();
            for (int i = 0;i < persona.Length; i++)
            {
                Console.WriteLine(" Nombre: " + persona[i].ReturnNombre());
                Console.WriteLine(" DNI: " + persona[i].ReturnDni());
                Console.WriteLine(" Peso de equipaje(en KG): " + persona[i].ReturnEquipaje());
                Console.WriteLine();
            }
        }
        public void PesoTotal()
        {
            float pesototal = 0;
            for (int i = 0; i < persona.Length; i++)
            {
                pesototal = persona[i].ReturnEquipaje() + pesototal;
            }
            Console.WriteLine("El peso total de todo los equipajes son: " + pesototal + "(KG)");
            Console.WriteLine();
        }
        public void PesoPermitido()
        {
            for (int i = 0; i < persona.Length; i++)
            {
                if (persona[i].ReturnEquipaje() > 23)
                {
                    Console.WriteLine($"El pasajero {persona[i].ReturnNombre()} con el Dni {persona[i].ReturnDni()} excede el limite permitido de peso con un peso de: {persona[i].ReturnEquipaje()}(KG)");
                    Console.WriteLine();
                }
            }
        }
        public void administracion()
        {
            Listado();
            PesoTotal();
            PesoPermitido();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Vuelo Av = new Vuelo();
            Av.administracion();

        }
    }
}
