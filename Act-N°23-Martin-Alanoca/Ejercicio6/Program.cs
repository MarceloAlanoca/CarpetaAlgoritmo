using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Libro
    {
        private string titulo;
        private int anioPublicacion;

        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }

        public int AnioPublicacion
        {
            set
            {
                anioPublicacion = value;
            }
            get 
            { 
                return anioPublicacion; 
            }
        }

        public Libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }
    }
    class BibliotecaCentral
    {
        List<Libro> ListaLibros = new List<Libro>();

        public void CargarCatalogo()
        {
            string titulo;

            do
            {
                Console.Write("Ingrese el titulo del libro (o FIN para terminar): ");
                titulo = Console.ReadLine();

                if (titulo.ToUpper() != "FIN")
                {
                    Console.Write("Ingrese el año de publicacion: ");
                    int anio = int.Parse(Console.ReadLine());

                    Libro libro = new Libro(titulo, anio);

                    ListaLibros.Add(libro);
                }

            } while (titulo.ToUpper() != "FIN");
        }

        public void ListarCatalogo()
        {
            foreach (Libro libro in ListaLibros)
            {
                Console.WriteLine($"Titulo: {libro.Titulo} - Año: {libro.AnioPublicacion}");
            }

            Console.WriteLine($"Cantidad total de obras: {ListaLibros.Count}");
        }

        public void FiltrarPorAnio()
        {
            Console.Write("Ingrese un año: ");
            int anio = int.Parse(Console.ReadLine());

            foreach (Libro libro in ListaLibros)
            {
                if (libro.AnioPublicacion < anio)
                {
                    Console.WriteLine($"Titulo: {libro.Titulo} - Año: {libro.AnioPublicacion}");
                }
            }
        }

        public void RemoverLibro()
        {
            Console.Write("Ingrese el titulo del libro que desea remover: ");
            string titulo = Console.ReadLine();

            Libro libroEncontrado = null;

            foreach (Libro libro in ListaLibros)
            {
                if (libro.Titulo == titulo)
                {
                    libroEncontrado = libro;
                    break;
                }
            }

            if (libroEncontrado != null)
            {
                ListaLibros.Remove(libroEncontrado);
                Console.WriteLine("Libro removido correctamente.");
            }
            else
            {
                Console.WriteLine("El libro no se encuentra en el catalogo.");
            }
        }
        static void Main(string[] args)
        {
            BibliotecaCentral biblioteca = new BibliotecaCentral();

            biblioteca.CargarCatalogo();

            Console.WriteLine("\n=== CATALOGO ===");
            biblioteca.ListarCatalogo();

            Console.WriteLine("\n=== FILTRAR POR AÑO ===");
            biblioteca.FiltrarPorAnio();

            Console.WriteLine("\n=== REMOVER LIBRO ===");
            biblioteca.RemoverLibro();

            Console.WriteLine("\n=== CATALOGO ACTUALIZADO ===");
            biblioteca.ListarCatalogo();

            Console.ReadKey();
        }
    }
}
