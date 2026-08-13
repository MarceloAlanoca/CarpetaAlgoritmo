using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio2
{
    /*
        Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
        drones de entrega en vuelo de regreso a la base.
         Crear la clase Dron que contenga los atributos privados: codigo (string) y
        nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
        Su constructor debe recibir cod y bat.
         Crear la clase CentroControl que administre una lista de objetos
        List&lt;Dron&gt;.
         Métodos en CentroControl:

        1. Un constructor que cargue por teclado una lista inicial de 4 drones
        ingresando sus códigos y baterías.
        2. ListarFlota(): Mostrar la lista de drones en pantalla.
        3. RemoverDronesBajos(): Recorrer la lista y remover por
        completo de la flota a todos aquellos drones cuyo nivel de batería
        sea menor o igual al 15% (ya que requieren mantenimiento
        automático urgente).
        4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
        cantidad de drones operativos utilizando la propiedad .Count.
     */
    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            set
            {
                codigo = value;
            }
            get
            {
                return codigo;
            }
        }
        public int NivelBateria
        {
            set
            {
                nivelBateria = value;
            }
            get
            {
                return nivelBateria;
            }
        }
        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;

            
        }
       
    }
    internal class CentroControl
    {
        List<Dron> D_drom = new List<Dron>();
        public CentroControl() 
        {
            Dron[] d = new Dron[3];

            for (int i = 0; i < d.Length; i++) 
            {
                Console.Write("Ingrese el codigo del Dron: ");
                string cod = Console.ReadLine();

                Console.Write("Ingrese la bateria del Dron(Si el valor es mayor a 100 o menor a 0 el valor por defecto sera 0): ");
                int bat = int.Parse(Console.ReadLine());

                if (bat < 0) 
                { 
                    bat = 0;
                }
                if (bat > 100) 
                {
                    bat = 0;
                }


                Dron DN = new Dron(cod, bat);
                
                Console.WriteLine();
                

                D_drom.Add(DN);
                
            }
            
        }
        public void ListarFlota()
        {
            Console.WriteLine("=== LISTA DE DRONES ===");
            foreach (Dron DN in D_drom)
            {
                
                Console.WriteLine($"Codigo del dron: {DN.Codigo}");

                Console.WriteLine($"Porcentaje de bateria del dron: {DN.NivelBateria}");
               

            }
            Console.WriteLine();
        }
        public void RemoverDronesBajos()
        {
            for (int i = D_drom.Count - 1; i >= 0; i--)
            {
                if (D_drom[i].NivelBateria <= 15)
                {
                    Console.WriteLine($"El dron {D_drom[i].Codigo} necesita mantenimiento.");
                    D_drom.RemoveAt(i);
                }
            }
            Console.WriteLine();
        }
        public void MostrarDronesRestantes()
        {

            Console.WriteLine("=== DRONES RESTANTES ===");

            foreach (Dron DN in D_drom)
            {
                Console.WriteLine($"Codigo del dron: {DN.Codigo}");
                Console.WriteLine($"Porcentaje de bateria: {DN.NivelBateria}%");
                Console.WriteLine();
            }

            Console.WriteLine($"Cantidad de drones operativos: {D_drom.Count}");
        }
        static void Main(string[] args)
        {
            
            CentroControl CC = new CentroControl();
            
            CC.ListarFlota();
            CC.RemoverDronesBajos();
            CC.MostrarDronesRestantes();
            Console.ReadKey();  
        }
    }
}
