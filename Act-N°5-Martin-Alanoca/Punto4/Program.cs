using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se cuenta con la siguiente información:
            //● Las edades de 20 estudiantes del turno mañana.
            //● Las edades de 30 estudiantes del turno tarde.
            //● Las edades de 15 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por teclado.
            //a) Obtener el promedio de las edades de cada turno(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            //promedio de edades menor.

            int Edad, Turno_M, Turno_T, Turno_N,
                Promedio_M, Promedio_T, Promedio_N;
            String Linea;
            Turno_M = 20;
            Turno_N = 30;
            Turno_T = 15;
            int Suma_M = 0;
            int Suma_T = 0;
            int Suma_N = 0;

            Console.WriteLine("ingrese la edades de cada alumno");
            Console.WriteLine("Turno mañana");
            for (int i = 1; i <= Turno_M; i++) {
                Console.Write(" Edad de Alumno N°" + i + ": ");
                Linea = Console.ReadLine();
                Edad = int.Parse(Linea);
                Suma_M = Edad + Suma_M;
            }

            Console.WriteLine("Turno tarde");
            for (int i = 1; i <= Turno_T; i++)
            {
                Console.Write(" Edad de Alumno N°" + i + ": ");
                Linea = Console.ReadLine();
                Edad = int.Parse(Linea);
                Suma_T = Edad + Suma_T;

            }

            Console.WriteLine("Turno noche");
            for (int i = 1; i <= Turno_N; i++)
            {
                Console.Write(" Edad de Alumno N°" + i + ": ");
                Linea = Console.ReadLine();
                Edad = int.Parse(Linea);
                Suma_N = Edad + Suma_N;

            }

            Promedio_M = Suma_M / Turno_M;
            Promedio_T = Suma_T / Turno_T;
            Promedio_N = Suma_N / Turno_N;

            Console.WriteLine("Promedio de turno Mañana: " + Promedio_M);
            Console.WriteLine("Promedio de turno Tarde: " + Promedio_T);
            Console.WriteLine("Promedio de turno Noche: " + Promedio_N);

            if (Promedio_T < Promedio_M && Promedio_T < Promedio_N) {
                Console.WriteLine("el promedio de edad de turno Tarde es menor con un promedio de: " + Promedio_T);
            }
            if (Promedio_M < Promedio_N && Promedio_M < Promedio_T) {
                Console.WriteLine("el promedio de edad de turno Mañana es menor con un promedio de: " + Promedio_M);
            }
            if (Promedio_N < Promedio_T && Promedio_N < Promedio_M) {
                Console.WriteLine("el promedio de edad de turno Noche es menor con un promedio de: " + Promedio_N);
            }

            Console.ReadKey();
        }
    }
}
