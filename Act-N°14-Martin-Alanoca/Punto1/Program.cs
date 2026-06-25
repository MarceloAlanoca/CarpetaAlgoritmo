using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
        1. El Sistema de Peaje.
        Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
        La clase Vehiculo debe tener los siguientes atributos privados:
        Patente (de tipo string).
        Tipo (puede ser "Auto", "Camion" o "Moto").
        Tarifa (un valor decimal que representa el costo de su pase).
        El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
        La clase CabinaPeaje debe tener como atributos privados:
        El número o identificador de la cabina.
        Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
        Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
        1 - Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
        2 - Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
        3 - Un método que muestre la patente del vehículo que pagó la tarifa más cara 
    */
    class Vehiculo
    {
        private string Patente;
        private string Tipo;
        private float Tarifa;

        public Vehiculo()
        {
            string linea;

            Console.WriteLine("Ingrese el numero de patente: ");
            linea = Console.ReadLine();
            Patente = linea;

            Console.WriteLine("Ingrese que tipo de vehiculo es: ");
            linea = Console.ReadLine();
            Tipo = linea;

            Console.WriteLine("Ingrese la tarifa designada: ");
            linea= Console.ReadLine();
            Tarifa = float.Parse(linea);

        }
        public string DevolverPatente()
        {
            return Patente;
        }
        public string DevolverTipo()
        {
            return Tipo;
        }
        public float DevolverTarifa()
        {
            return Tarifa;
        }
    }

    internal class CabinaPeaje
    {
        private Vehiculo vehiculo1, vehiculo2, vehiculo3;
        private int numcabina;

        public CabinaPeaje()
        { 
            string linea;
            Console.WriteLine("Ingrese el número de la cabina: ");
            linea = Console.ReadLine();
            numcabina = int.Parse(linea);

            Console.WriteLine("\n--- Cargando Vehículo 1 ---");
            vehiculo1 = new Vehiculo(); 

            Console.WriteLine("\n--- Cargando Vehículo 2 ---");
            vehiculo2 = new Vehiculo();

            Console.WriteLine("\n--- Cargando Vehículo 3 ---");
            vehiculo3 = new Vehiculo();
            Console.WriteLine();
        }
        public void Imprimir()
        {
            Console.WriteLine("Mostrando datos de vehiculo N°1: ");
            Console.WriteLine($"-- Patente: {vehiculo1.DevolverPatente()}");
            Console.WriteLine($"-- Tipo: {vehiculo1.DevolverTipo()}");

            Console.WriteLine("Mostrando datos de vehiculo N°2: ");
            Console.WriteLine($"-- Patente: {vehiculo2.DevolverPatente()}");
            Console.WriteLine($"-- Tipo: {vehiculo2.DevolverTipo()}");

            Console.WriteLine("Mostrando datos de vehiculo N°3: ");
            Console.WriteLine($"-- Patente: {vehiculo3.DevolverPatente()}");
            Console.WriteLine($"-- Tipo: {vehiculo3.DevolverTipo()}");
        }
        public void SumaTarifa()
        {
            float num1 = vehiculo1.DevolverTarifa();
            float num2 = vehiculo2.DevolverTarifa();
            float num3 = vehiculo3.DevolverTarifa();

            float total = num1 + num2 + num3;

            Console.WriteLine("la suma de las tarifas es: " + total);
            Console.WriteLine();
        }
        public void MayorTarifa()
        {
            
            float mayor = 0;
            float vehi1 = vehiculo1.DevolverTarifa();
            float vehi2 = vehiculo2.DevolverTarifa();
            float vehi3 = vehiculo3.DevolverTarifa();
            if (vehi1 > mayor)
            {
                mayor = vehi1;
                 
            }
            if (vehi2 > mayor)
            {
                mayor = vehi2;
                 
            }
            if (vehi3 > mayor)
            {
                mayor = vehi3;
                 
            }
            if (vehi1 == vehi2 && vehi2 == vehi3)
            {
                Console.WriteLine("Todas las tarifas son iguales a: " + vehi1);
            }
            else
            {
                Console.WriteLine("La mayor tarifa es: " + mayor);
            }
        }
        public void Cabina()
        {
            Imprimir();
            SumaTarifa();
            MayorTarifa();

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            CabinaPeaje Cab = new CabinaPeaje();
            Cab.Cabina();
            
        }
    }
}
