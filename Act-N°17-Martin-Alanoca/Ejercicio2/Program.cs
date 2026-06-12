using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Pelicula
    {
        private string titulo;
        private float duracionminutos;
        private float calificacion;
        
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
        public float DuracionMinutos
        {
            set
            {
                duracionminutos = value;
            }
            get 
            { 
                return duracionminutos; 
            }
        }
        public float Calificacion
        {
            set 
            { 
                calificacion = value; 
            }
            get
            {
                return calificacion;
            }
        }
        public Pelicula()
        {
            String linea;
            Console.Write("Ingrese el titulo de la pelicula: ");
            linea = Console.ReadLine();
            Titulo = linea;

            Console.Write("Ingrese la duracion de la pelicula en Min: ");
            linea = Console.ReadLine();
            DuracionMinutos = float.Parse(linea);

            Console.Write("Ingrese la calificacion: ");
            linea = Console.ReadLine();
            Calificacion = float.Parse(linea);
        }
        public void coreccion()
        {
            if (calificacion > 5)
            {
                calificacion = 1;
            }
        }
    }
    internal class Catalogo
    {
        private Pelicula[] pelicula;

        public Catalogo()
        {
            pelicula = new Pelicula[3];
            
            for (int i = 0; i < pelicula.Length; i++)
            {
                pelicula[i] = new Pelicula();
               
            }   
        }
        static void Main(string[] args)
        {
            Catalogo Cat = new Catalogo();
            
            
            for (int i = 0; i < 3; i++) 
            {
                Cat.pelicula[i].coreccion();
                Console.WriteLine("calificacion: " + Cat.pelicula[i].Calificacion);
            }
            Console.ReadKey();
        }
    }
}