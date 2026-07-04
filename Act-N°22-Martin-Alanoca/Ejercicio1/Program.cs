using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio1
{
    class ClaseGimnasio
    {
        /*
            Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
            DateTime).
            ● Implementar un constructor que permita cargar los datos desde consola y otro
            que cargue valores por defecto (sobrecarga de constructores).
            ● Incluir un método para calcular la duración de la clase usando TimeSpan.
            ● Crear un vector de 3 clases de gimnasio y mostrar:
            1. La clase que tenga la mayor duración.
            2. El nombre y el horario de inicio de la clase más temprana.
         */
        private string nombreClase;
        private DateTime horaInicio;
        private DateTime horaFin;

        public string NombreClase
        {
            set
            {
                nombreClase = value;
            }
            get
            {
                return nombreClase;
            }
        }
        public DateTime HoraInicio
        {
            set 
            { 
                horaInicio = value; 
            }
            get 
            { 
                return horaInicio; 
            }
        }
        public DateTime HoraFin
        {
            set 
            {
                horaFin = value; 
            }
            get
            {
                return horaFin;
            }
        }
        public ClaseGimnasio()
        {
            nombreClase = "x";
            horaInicio = DateTime.Now;
            horaFin = DateTime.Now;
        }
        public ClaseGimnasio(string nombre, DateTime hi, DateTime hf)
        {
            this.nombreClase = nombre;
            this.horaInicio = hi;
            this.horaFin = hf;
        }
        public TimeSpan Calculotiempo()
        {
            return HoraFin - HoraInicio;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseGimnasio[] gimnasio = new ClaseGimnasio[3];

            for (int i = 0; i < gimnasio.Length; i++) 
            {
                Console.WriteLine("Ingrese el nombre de la clase: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el horario de inicio de la clase(Hora:minutos): ");
                DateTime hi = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el horario del fin de la clase(Hora:minutos): ");
                DateTime hf = DateTime.Parse(Console.ReadLine());

                gimnasio[i] = new ClaseGimnasio(nombre, hi, hf);
                Console.WriteLine();
            }

            TimeSpan MayorTiempo = gimnasio[0].Calculotiempo();
            string Mayornombre = gimnasio[0].NombreClase;

            DateTime TiempoTemprano = gimnasio[0].HoraInicio;
            string nombreTemprano = gimnasio[0].NombreClase;


            for (int i = 0; i < gimnasio.Length; i++)
            {
                TimeSpan Duracion = gimnasio[i].Calculotiempo();
                if(Duracion > MayorTiempo)
                {
                    MayorTiempo = Duracion;
                    Mayornombre = gimnasio[i].NombreClase;
                }

                if (gimnasio[i].HoraInicio < TiempoTemprano)
                {
                    TiempoTemprano = gimnasio[i].HoraInicio;
                    nombreTemprano = gimnasio[i].NombreClase;
                }
            }
            Console.WriteLine("---Cargando---");
            Console.WriteLine("la clase mas larga es la: " + Mayornombre + "\n con la duracion de: " + MayorTiempo);
            Console.WriteLine("la clase mas corta es la: " + nombreTemprano + "\n con la duracion de: " + TiempoTemprano.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
