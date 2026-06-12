using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class PersonaGimnasio
    {
        private string nombre;
        private int dni;

        public string Nombre 
        { 
            set 
            { 
                nombre = value; 
            }
            get
            { 
                return nombre; 
            }
        }
        public int Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }
       
        
    }
    class Profesor : PersonaGimnasio 
    {
        private string especialidad;
        
        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }
    }
    internal class Gym
    {
        private PersonaGimnasio persona1, persona2;
        private Profesor profesor;

        public Gym()
        {
            persona1 = new PersonaGimnasio();
            persona1.Nombre = "Pablo";
            persona1.Dni = 49123123; 
            persona2 = new PersonaGimnasio();
            persona2.Nombre = "Nilt";
            persona2.Dni = 49316121;
            profesor = new Profesor();
            profesor.Nombre = "Marcos";
            profesor.Dni = 12234123;
            profesor.Especialidad = "Programar";
        }
        public void Imprimir()
        {
            Console.WriteLine("--cargando datos de la persona--");
            Console.WriteLine();
            Console.WriteLine($"    Nombre de la persona {persona1.Nombre} y su dni {persona1.Dni}");
            Console.WriteLine($"    Nombre de la persona {persona2.Nombre} y su dni {persona2.Dni}");
            Console.WriteLine();
            Console.WriteLine("--cargando datos de la persona--");
            Console.WriteLine();
            Console.WriteLine($"    Nombre del profesor {profesor.Nombre} y su dni {profesor.Dni} y su especialidad {profesor.Especialidad}");
        }
        static void Main(string[] args)
        {

            Gym G = new Gym();
            G.Imprimir();
            Console.ReadKey();
            
        
            
        }
    }
}
    

