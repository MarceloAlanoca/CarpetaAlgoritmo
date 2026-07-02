using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        /*
            Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
            sus nombres y puntajes promedio obtenidos (de 1 a 10).
            Cargar sus datos en vectores paralelos, mostrar docente con calificación más
            alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
            calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
            desaprobaron (tomando como base que se aprueba con una nota mayor o igual
            a 6)
        */

        private string[] Docentes;
        private int[] Puntaje;
        public void Inicio()
        {
            Docentes = new string[6];
            Puntaje = new int[6];
            for (int i = 0; i < Docentes.Length; i++)
            {
                Console.WriteLine("Ingresa nombre de un docente: ");
                Docentes[i] = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Ingresa su puntuación del 1 al 10: ");
                    int valor = int.Parse(Console.ReadLine());

                    if (valor >= 1 && valor <= 10)
                    {
                        Puntaje[i] = valor;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor invalido, del 1 al 10 solamente.");
                    }
                }
            }
        }
        public void Mostrar()
        {
            int caprobados = 0;
            int cdesaprobados = 0;
            for (int i = 0; i < Docentes.Length - 1; i++)
            {
                for (int j = 0; j < Docentes.Length - 1 - i; j++)
                {
                    if (Puntaje[j] < Puntaje[j + 1])
                    {
                        int aux = Puntaje[j];
                        Puntaje[j] = Puntaje[j + 1];
                        Puntaje[j + 1] = aux;

                        string aux2 = Docentes[j];
                        Docentes[j] = Docentes[j + 1];
                        Docentes[j + 1] = aux2;
                    }
                }
            }
            Console.WriteLine("Profesores y sus notas (de mayor a menor): ");
            for (int i = 0; i < Docentes.Length; i++)
            {
                Console.WriteLine(Docentes[i] + " Con la calificación de: " + Puntaje[i]);
            }
            Console.WriteLine("Docente con la calificación más baja es: " + Docentes[Docentes.Length - 1]);
            Console.WriteLine("Docente con la calificación más alta es: " + Docentes[0]);
            for (int i = 0; i < Docentes.Length; i++)
            {
                if (Puntaje[i] >= 6)
                {
                    caprobados++;
                }
                else
                {
                    cdesaprobados++;
                }
            }
            Console.WriteLine("Cantidad de docentes aprobados: " + caprobados);
            Console.WriteLine("Cantidad de docentes desaprobados: " + cdesaprobados);

        }
        public void MostrandoValores()
        {
            Inicio();
            Mostrar();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MostrandoValores();
        }
    }
}
