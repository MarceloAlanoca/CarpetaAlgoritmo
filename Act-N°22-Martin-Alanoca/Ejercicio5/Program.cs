using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    /*
     Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
        una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
        Se pide:
        1. Crear una clase Carrera con:
        o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
        definidos.
        o Dos constructores (uno por defecto y otro con parámetros).
        o Método para calcular la duración de la carrera usando TimeSpan.
        2. Crear una clase Corredor con:
        o Atributos: nombre, número de dorsal y tiempo total.
        o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
        horas y minutos).

        3. Mostrar en consola (usando Console.SetCursorPosition()):
        o La carrera con mayor duración.
        o El corredor más rápido.
        4. Utilizar this en los constructores o métodos donde corresponda.
        5. Deben ser 4 carreras.
     */
    class Corredor
    {
        private string nombre;
        private int dorsal;
        private int tiempoTotal;

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

        public int Dorsal
        {
            set 
            { 
                dorsal = value; 
            }
            get 
            { 
                return dorsal; 
            }
        }

        public int TiempoTotal
        {
            set 
            { 
                tiempoTotal = value; 
            }
            get 
            { 
                return tiempoTotal; 
            }
        }

        public Corredor()
        {
            nombre = "X";
            dorsal = 0;
            tiempoTotal = 0;
        }

        public Corredor(string nombre, int dorsal)
        {
            this.nombre = nombre;
            this.dorsal = dorsal;
            tiempoTotal = 0;
        }

        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = minutos;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoTotal = horas * 60 + minutos;
        }
    }

    class Carrera
    {
        private string codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> corredores;

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

        public List<Corredor> Corredores
        {
            get 
            { 
                return corredores; 
            }
        }

        public Carrera()
        {
            codigo = "X";
            horaInicio = DateTime.Now;
            horaFin = DateTime.Now;
            corredores = new List<Corredor>();
        }

        public Carrera(string cod, DateTime i, DateTime f)
        {
            this.codigo = cod;
            this.horaInicio = i;
            this.horaFin = f;
            corredores = new List<Corredor>();
        }

        public TimeSpan CalcularDuracion()
        {
            return horaFin - horaInicio;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carrera[] carreras = new Carrera[4];

            for (int i = 0; i < carreras.Length; i++)
            {
                Console.Clear();

                Console.WriteLine("Carrera: " + (i + 1));

                Console.Write("Código: ");
                string codigo = Console.ReadLine();

                Console.Write("Hora de inicio (Horas:Minutos): ");
                DateTime inicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Hora de fin (Horas:Minutos): ");
                DateTime fin = DateTime.Parse(Console.ReadLine());

                carreras[i] = new Carrera(codigo, inicio, fin);

                Console.Write("Cantidad de corredores: ");
                int cantidad = int.Parse(Console.ReadLine());

                for (int j = 0; j < cantidad; j++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Corredor: " + (j + 1));

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Dorsal: ");
                    int dorsal = int.Parse(Console.ReadLine());

                    Corredor c = new Corredor(nombre, dorsal);

                    Console.WriteLine("1 ingresar en Minutos");
                    Console.WriteLine("2 ingresar en Horas y minutos");
                    Console.Write("Opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.Write("Minutos: ");
                        int minutos = int.Parse(Console.ReadLine());

                        c.RegistrarTiempo(minutos);
                    }
                    else
                    {
                        Console.Write("Horas: ");
                        int horas = int.Parse(Console.ReadLine());

                        Console.Write("Minutos: ");
                        int minutos = int.Parse(Console.ReadLine());

                        c.RegistrarTiempo(horas, minutos);
                    }

                    carreras[i].Corredores.Add(c);
                }
            }

            Carrera carreraMayor = carreras[0];

            for (int i = 1; i < carreras.Length; i++)
            {
                if (carreras[i].CalcularDuracion() > carreraMayor.CalcularDuracion())
                {
                    carreraMayor = carreras[i];
                }
            }

            Corredor corredorRapido = carreras[0].Corredores[0];

            for (int i = 0; i < carreras.Length; i++)
            {
                for (int j = 0; j < carreras[i].Corredores.Count; j++)
                {
                    if (carreras[i].Corredores[j].TiempoTotal < corredorRapido.TiempoTotal)
                    {
                        corredorRapido = carreras[i].Corredores[j];
                    }
                }
            }

            Console.Clear();

            Console.CursorVisible = false;

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Carrera con mayor duración");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Código: " + carreraMayor.Codigo);

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Duración: " + carreraMayor.CalcularDuracion());

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Corredor más rápido");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Nombre: " + corredorRapido.Nombre);

            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Dorsal: " + corredorRapido.Dorsal);

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Tiempo: " + corredorRapido.TiempoTotal + " minutos");

            Console.CursorVisible = true;
            Console.SetCursorPosition(3, 15);

            Console.ReadKey();
        }
    }
}
