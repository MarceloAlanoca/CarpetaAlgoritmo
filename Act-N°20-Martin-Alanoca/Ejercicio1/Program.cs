using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Vuelo
    {
        private int nru_vuelo;
        private string destino;
        private int duracionhoras;
        public int Nru_vuelo
        {
            set
            {
                nru_vuelo = value;
            }
            get
            {
                return nru_vuelo;
            }
        }
        public string Destino
        {
            set
            {
                destino = value;
            }
            get
            {
                return destino;
            }
        }
        public int Duracionhoras
        {
            set
            {
                duracionhoras = value;
            }
            get
            {
                return duracionhoras;
            }
        } 
    }
    internal class VueloInternacional : Vuelo
    {
        /*
            Problema:
            Una aerolínea administra los vuelos programados mediante un sistema orientado a
            objetos.
            Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
            destino y duración en horas. Luego definir una clase derivada VueloInternacional que
            herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
            Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
            desde consola y luego:
             Mostrar los vuelos registrados y el país de destino.
             Informar cuál es el vuelo con mayor duración.
             Mostrar el orden de ejecución de los constructores.
         */
        Vuelo[] vuelos;
        private string paisDestino;
        public string PaisDestino
        {
            set
            {
                paisDestino = value;
            }
            get
            {
                return paisDestino;
            }
        }
        static void Main(string[] args)
        {


            List<VueloInternacional> vuelos = new List<VueloInternacional>();

            for (int i = 0; i < 1; i++)
            {
                VueloInternacional vuelo = new VueloInternacional();

                Console.Write("Número de vuelo: ");
                vuelo.Nru_vuelo = int.Parse(Console.ReadLine());

                Console.Write("Destino: ");
                vuelo.Destino = Console.ReadLine();

                Console.Write("Duración en horas: ");
                vuelo.Duracionhoras = int.Parse(Console.ReadLine());

                Console.Write("País de destino: ");
                vuelo.PaisDestino = Console.ReadLine();

                vuelos.Add(vuelo);
                Console.WriteLine();
            }

            Console.WriteLine("--- Vuelos Registrados ---");

            foreach (VueloInternacional vuelo in vuelos)
            {
                Console.WriteLine("Número: " + vuelo.Nru_vuelo);
                Console.WriteLine("Destino: " + vuelo.Destino);
                Console.WriteLine("Duración: " + vuelo.Duracionhoras + " horas");
                Console.WriteLine("País: " + vuelo.PaisDestino);
                Console.WriteLine();
            }

            VueloInternacional mayor = vuelos[0];

            foreach (VueloInternacional vuelo in vuelos)
            {
                if (vuelo.Duracionhoras > mayor.Duracionhoras)
                {
                    mayor = vuelo;
                }
            }

            Console.WriteLine("--- Vuelo con mayor duracion ---");
            Console.WriteLine("Número: " + mayor.Nru_vuelo);
            Console.WriteLine("Destino: " + mayor.Destino);
            Console.WriteLine("País: " + mayor.PaisDestino);
            Console.WriteLine("Duración: " + mayor.Duracionhoras + " horas");


        }
    }
}
