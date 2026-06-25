using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
        2. Control de Vuelos
        Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
        Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar
        la carga por teclado de cada uno de los 4 pasajeros.
        Agregar los siguientes métodos en la clase Vuelo:
        Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
        Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
        Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI. 
    */
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
