using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /*
     Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
    ● Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
    1. Uno que reciba horas y minutos y los convierta a minutos.
    2. Otro que reciba directamente los minutos.
    ● Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
    más corto.
     */
    class Entrenamiento
    {
        private string deportista;
        private int duracion;

        public string Deportista {
            set
            {
                deportista = value;
            }
            get
            {
                return deportista;
            }
        }
        public int Duracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }
        public Entrenamiento()
        {
            this.deportista = "X";
            duracion = 0;
        }
        public Entrenamiento(string dep)
        {
            this.deportista = dep;
            duracion = 0;
        }
        public void RegistrarDuracion(int minutos)
        {
            duracion = minutos;
        }
        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = horas * 60 + minutos;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entrenamiento " + (i + 1));

                Console.Write("Nombre del deportista: ");
                string nombre = Console.ReadLine();

                Entrenamiento e = new Entrenamiento(nombre);

                Console.WriteLine("¿Como desea ingresar la duracion?");
                Console.WriteLine("1 para ingresar en minutos");
                Console.WriteLine("2 para ingresar en horas y minutos");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    e.RegistrarDuracion(minutos);
                }
                else
                {
                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    e.RegistrarDuracion(horas, minutos);
                }

                entrenamientos.Add(e);

                Console.WriteLine();
            }

            Entrenamiento MayorEntrenamiento = entrenamientos[0];
            Entrenamiento MenorEntrenamiento = entrenamientos[0];

            for (int i = 1; i < entrenamientos.Count; i++)
            {
                if (entrenamientos[i].Duracion > MayorEntrenamiento.Duracion)
                {
                    MayorEntrenamiento = entrenamientos[i];
                }

                if (entrenamientos[i].Duracion < MenorEntrenamiento.Duracion)
                {
                    MenorEntrenamiento = entrenamientos[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Entrenamiento mas largo es" + "\n Deportista: " + MayorEntrenamiento.Deportista + "\n Duración: " + MayorEntrenamiento.Duracion +  " minutos");
            Console.WriteLine();
            Console.WriteLine("Entrenamiento mas corto es" + "\n Deportista: " + MenorEntrenamiento.Deportista + "\n Duración: " + MenorEntrenamiento.Duracion +  " minutos");
            Console.ReadKey();
        }
    }
    
}
