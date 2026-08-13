using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    /*
        Un taller mecánico automatizado administra la recepción y egreso de automóviles
        que se encuentran en el sector de reparaciones.
         Crear la clase Vehiculo que contenga como atributos privados: patente
        (string) y costoReparacion (double). Definir sus propiedades
        correspondientes y un constructor que reciba pat y costo.
         Crear la clase GestionTaller que administre una lista de objetos List.
         Métodos en GestionTaller:
        o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
        reparación de un vehículo para agregarlo a la lista mediante .Add().
        o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
        recorriendo la lista, informar si el vehículo está en el taller y mostrar
        su costo asociado.
        o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
        vehículo en la lista y, si existe, removerlo de la colección mediante
        .Remove() confirmando la entrega del automóvil.

        o CalcularRecaudacionPendiente(): Listar los vehículos
        actualmente en reparación, la cantidad total de unidades alojadas en
        el taller mediante la propiedad .Count y la suma total acumulada por
        cobrar.
     */
    class Vehiculo
    {
        private string patente;
        private double costoreparacion;

        public string Patente
        {
            set
            {
                this.patente = value;
            }
            get
            {
                return this.patente;
            }
        }
        public double Costoreparacion
        {
            set
            {
                this.costoreparacion = value;
            }
            get
            {
                return this.costoreparacion;
            }
        }
        public Vehiculo(string pat, double costo)
        {
            this.patente = pat;
            this.costoreparacion = costo;
        }
    }
    internal class GestionTaller
    {
        List<Vehiculo> ListVehiculo = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            string pat;

            do
            {
                Console.Write("Ingrese la patente del vehiculo (o FIN para terminar): ");
                pat = Console.ReadLine();

                if (pat.ToUpper() != "FIN")
                {
                    Console.Write("Ingrese el costo de reparacion del vehiculo: ");
                    double costo = double.Parse(Console.ReadLine());

                    Vehiculo vehiculo = new Vehiculo(pat, costo);

                    ListVehiculo.Add(vehiculo);

                    Console.WriteLine("Vehiculo ingresado correctamente.");
                }

            } while (pat.ToUpper() != "FIN");
        }
        public void BuscarVehiculo()
        {
            Console.Write("Ingrese la patente a buscar: ");
            string pat = Console.ReadLine();

            bool encontrado = false;

            foreach (Vehiculo vehiculo in ListVehiculo)
            {
                if (vehiculo.Patente == pat)
                {
                    Console.WriteLine("El vehiculo se encuentra en el taller.");
                    Console.WriteLine($"Costo de reparacion: ${vehiculo.Costoreparacion}");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El vehiculo no se encuentra en el taller.");
            }
        }
        public void EntregarVehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo a entregar: ");
            string pat = Console.ReadLine();

            Vehiculo vehiculoEncontrado = null;

            foreach (Vehiculo vehiculo in ListVehiculo)
            {
                if (vehiculo.Patente == pat)
                {
                    vehiculoEncontrado = vehiculo;
                    break;
                }
            }

            if (vehiculoEncontrado != null)
            {
                ListVehiculo.Remove(vehiculoEncontrado);
                Console.WriteLine("Vehiculo entregado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontro un vehiculo con esa patente.");
            }
        }    
        public void CalcularRecaudacionPendiente()
        { 
            double total = 0;

            Console.WriteLine("Vehiculos actualmente en reparacion:");

            foreach (Vehiculo vehiculo in ListVehiculo)
            {
                Console.WriteLine($"Patente: {vehiculo.Patente} - Costo: ${vehiculo.Costoreparacion}");

                total += vehiculo.Costoreparacion;
            }

            Console.WriteLine($"Cantidad de vehiculos: {ListVehiculo.Count}");
            Console.WriteLine($"Total pendiente de cobrar: ${total}");
        
        }
        static void Main(string[] args)
        {
            GestionTaller taller = new GestionTaller();
            taller.IngresarVehiculo();
            taller.BuscarVehiculo();
            taller.CalcularRecaudacionPendiente();
            taller.EntregarVehiculo();
            taller.CalcularRecaudacionPendiente();

            Console.ReadKey();
        }
    }
}
