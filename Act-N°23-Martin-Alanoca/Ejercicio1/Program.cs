using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio1
{
    /*
        En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
        llegada.
         Crear la clase Documento que contenga como atributos privados:
        nombreArchivo (string) y cantidadPaginas (int). Definir sus
        propiedades de solo lectura y un constructor que reciba los parámetros nom
        y pag.
         Crear la clase ServidorImpresion que administre una lista dinámica de
        documentos (List&lt;Documento&gt;).
         Métodos en ServidorImpresion:
        1. AgregarDocumento(): Solicitar por teclado los datos de un
        documento y agregarlo al final de la lista utilizando .Add().
        2. ImprimirSiguiente(): Si la lista no está vacía, simular la
        impresión del primer documento de la lista (mostrar sus datos en
        consola) y removerlo de la colección mediante .RemoveAt(0). Si está
        vacía, advertir que no hay trabajos pendientes.
        3. MostrarColaPendiente(): Listar todos los documentos que
        están esperando ser impresos y la cantidad total de páginas
        acumuladas en la cola de espera utilizando .Count.
     */
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo{
            set
            {
                nombreArchivo = value;
            }
            get
            {
                return nombreArchivo;
            }
        }
        public int CantidadPaginas
        {
            set
            {
                cantidadPaginas = value;
            }
            get
            {
                return cantidadPaginas;
            }
        }

        public Documento(String nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas= pag;
        }
    }
    internal class ServidorImpresion
    {
        List<Documento> Documentos = new List<Documento>();
        public void AgregarDocumento()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el nombre del documento: ");
                string nom = Console.ReadLine();

                Console.Write("Ingrese la cantidad de paginas: ");
                int pag = int.Parse(Console.ReadLine());

                Documento Doc = new Documento(nom, pag);
                Console.WriteLine();

                Documentos.Add(Doc);
            }
            Console.WriteLine("se guardo correctamente en la lista");
            Console.WriteLine();
        }
        public void ImprimirSiguiente() 
        {
            if (Documentos.Count > 0)
            {
                Console.WriteLine("Imprimiendo el primer documento");
                Documento doc = Documentos[0]; 
                Console.WriteLine("Documento a imprimir:"); 
                Console.WriteLine($"Nombre: {doc.NombreArchivo}"); 
                Console.WriteLine($"Cantidad de páginas: {doc.CantidadPaginas}"); 
                Documentos.RemoveAt(0); Console.WriteLine("Documento impreso correctamente."); 
            } 
            else 
            { 
                Console.WriteLine("No hay tareas pendientes."); 
            }
            Console.WriteLine();
        }
        public void MostrarColaPendiente() 
        {
            foreach (Documento D in Documentos) 
            { 
                Console.WriteLine($"Nombre: {D.NombreArchivo}"); 
                Console.WriteLine($"Cantidad de páginas: {D.CantidadPaginas}"); 
                totalPaginas += D.CantidadPaginas; 
            } 
            Console.WriteLine($"Total de páginas pendientes: {totalPaginas}"); 
        }
        static void Main(string[] args)
        {
            ServidorImpresion Si = new ServidorImpresion();
            Si.AgregarDocumento();
            Si.ImprimirSiguiente();
            Si.MostrarColaPendiente();
            Console.ReadKey();

        }
    }
}
