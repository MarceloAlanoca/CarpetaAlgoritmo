using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Vuelo
    {
        /*
         Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
        ● Usar la palabra clave this en el constructor para diferenciar los parámetros de
        los atributos.
        ● Crear un método para calcular la duración del vuelo (TimeSpan).
        ● Cargar un vector con 4 vuelos y mostrar:
        1. El código y duración del vuelo más largo.
        2. El código del vuelo que salga más temprano.
         */

        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

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
        public DateTime HoraSalida
        {
            set
            {
                horaSalida = value;
            }
            get
            {
                return horaSalida;
            }
        }
        public DateTime HoraLlegada
        {
            set
            {
                horaLlegada = value;
            }
            get
            {
                return horaLlegada;
            }
        }
        public Vuelo(string cod, DateTime hs, DateTime hl)
        {
            this.codigo = cod;
            this.horaSalida = hs;
            this.horaLlegada = hl;
        }
        public TimeSpan Duracion()
        {
            return HoraLlegada - HoraSalida;
        }

        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[2];

            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.Write("Código: ");
                string codigo = Console.ReadLine();

                Console.Write("Hora de salida (Horas:Minutos): ");
                DateTime salida = DateTime.Parse(Console.ReadLine());

                Console.Write("Hora de llegada (Horas:Minutos): ");
                DateTime llegada = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new Vuelo(codigo, salida, llegada);
            }

            TimeSpan mayorDuracion = vuelos[0].Duracion();
            string codigoMayor = vuelos[0].Codigo;

            DateTime salidaTemprana = vuelos[0].HoraSalida;
            string codigoTemprano = vuelos[0].Codigo;

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].Duracion() > mayorDuracion)
                {
                    mayorDuracion = vuelos[i].Duracion();
                    codigoMayor = vuelos[i].Codigo;
                }
                if (vuelos[i].HoraSalida < salidaTemprana)
                {
                    salidaTemprana = vuelos[i].HoraSalida;
                    codigoTemprano = vuelos[i].Codigo;
                }
            }
            Console.WriteLine("---Cargando---");
            Console.WriteLine("El vuelo mas largo es: " + codigoMayor + "\n Con la duracion de: " + mayorDuracion);
            Console.WriteLine("El vuelo mas corto es: " + codigoTemprano + "\n Con la duracion de: " + salidaTemprana.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
