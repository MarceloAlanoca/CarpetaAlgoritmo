using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /*
        Un restaurante automatizado procesa la comanda de una mesa para controlar la
        preparación y el cobro de los platos pedidos.
             Crear la clase Plato que contenga como atributos privados: nombrePlato
            (string) y precio (double). Definir sus propiedades correspondientes y un
            constructor que reciba nom y pre.
             Crear la clase GestionComandas que administre una lista de objetos List.
             Métodos en GestionComandas:
            o AgregarPlato():Solicitar por teclado los datos de un plato y
            agregarlo a la lista utilizando .Add().
            o MostrarComanda(): Listar todos los platos agregados hasta el
            momento junto a la cantidad total de ítems pedidos utilizando la
            propiedad .Count.
            o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
            total a cobrar sumando los precios de la lista.
            o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
            se encuentra en la lista, removerlo mediante .Remove() para
            actualizar la comanda.
     */
    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            set
            {
                nombrePlato = value;
            }
            get
            {
                return nombrePlato;
            }
        }
        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }
        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
    }
    internal class GestionComandas
    {
        List<Plato> platos = new List<Plato>();

        public void AgregarPlato()
        {
            string nom;
            do
            {
                Console.Write("Ingrese el nombre del plato (o ponga FIN para terminar): ");
                nom = Console.ReadLine();
                if (nom.ToUpper() != "FIN")
                {
                    Console.Write("Ingrese el precio del plato: ");
                    double pre = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Plato PlatoPedido = new Plato(nom, pre);
                    platos.Add(PlatoPedido);
                }
            }while (nom.ToUpper() != "FIN");
        }
        public void MostrarComanda()
        {
            Console.WriteLine("=== CARGANDO PLATILLOS ===");
            Console.WriteLine();
            for (int i = 0; i < platos.Count; i++)
            {
                Console.WriteLine($"nombre del plato: {platos[i].NombrePlato}\n precio: {platos[i].Precio}$");
            }
        }
        public void CalcularTotalMesa()
        {
            double totalprecio = 0;
            foreach (Plato plato in platos)
            {
                totalprecio += plato.Precio;
            }
            Console.WriteLine($"La cantidad total de platos pedidos fueron: {platos.Count}");
            Console.WriteLine($"Sumando cada precio de cada plato da una cantidad de: {totalprecio}");
        }
        public void CancelarPlato()
        {
            string respuesta;
            Console.WriteLine();
            Console.WriteLine("Desea cancelar un plato?(s/n)");
            respuesta = Console.ReadLine();
            Console.WriteLine();
            if(respuesta.ToUpper() == "S")
            {
                Console.WriteLine("ingrese el nombre del plato que quiere borrar");
                string nom = Console.ReadLine();

                Plato PlatoEncontrado = null;
                foreach (Plato plato in platos)
                {
                    if (plato.NombrePlato == nom)
                    {
                        PlatoEncontrado = plato;
                        break;
                    }
                }
                if (PlatoEncontrado != null)
                {
                    platos.Remove(PlatoEncontrado);
                    Console.WriteLine();
                    Console.WriteLine("El plato a sido removido correctamente.");
                    Console.WriteLine();

                    Console.WriteLine("=== MOSTRANDO LA LISTA ACTUALIZADA ===");
                    for (int i = 0; i < platos.Count; i++)
                    {
                        Console.WriteLine($"nombre del plato: {platos[i].NombrePlato}\n precio: {platos[i].Precio}$");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro un plato con ese nombre.");
                }
            }
            if (respuesta.ToUpper() == "N")
            {
                Console.WriteLine("Gracias siga continuando");
            }
            if(respuesta.ToUpper() != "S" && respuesta.ToUpper() != "N"  ) 
            {
                Console.WriteLine("Por favor ingrese s/n");
                CancelarPlato(); 
            }
        }
        public static void Main(string[] args)
        {
            GestionComandas GC = new GestionComandas();
            GC.AgregarPlato(); 
            GC.MostrarComanda();
            GC.CalcularTotalMesa();
            GC.CancelarPlato();
            Console.ReadKey();
        }
    }
}