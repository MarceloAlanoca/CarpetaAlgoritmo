using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
       vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
       alumno y sus 4 calificaciones.

       Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
       Alumno.

       Agregar los siguientes métodos:
       a) Un método que imprima el nombre de cada alumno y su promedio.
       b) Un método que muestre el nombre del alumno con el promedio más
       alto.
       c) Un método que indique qué alumnos tienen al menos una nota
       desaprobada (nota menor a 6)
    */

    class Alumnos
    {
        private string Alumno;
        private int[] notas;

        public Alumnos()
        {
            notas = new int[4];

            Console.WriteLine("Ingrese el nombre del alumno");
            Alumno = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i + 1));
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public string RetornarNombre()
        {
            return Alumno;
        }

        public double Promedio()
        {
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                suma = suma + notas[i];
            }

            return suma / 4.0;
        }

        public bool Desaprobado()
        {
            for (int i = 0; i < 4; i++)
            {
                if (notas[i] < 6)
                {
                    return true;
                }
            }

            return false;
        }
    }

    internal class Curso
    {
        private Alumnos[] Estudiante;

        public Curso()
        {
            Estudiante = new Alumnos[3];

            for (int i = 0; i < 3; i++)
            {
                Estudiante[i] = new Alumnos();
            }
        }

        public void Promedios()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno: " + Estudiante[i].RetornarNombre());
                Console.WriteLine("Promedio: " + Estudiante[i].Promedio());
            }
        }

        public void MejorPromedio()
        {
            double mayor = Estudiante[0].Promedio();
            string nombre = Estudiante[0].RetornarNombre();

            for (int i = 1; i < 3; i++)
            {
                if (Estudiante[i].Promedio() > mayor)
                {
                    mayor = Estudiante[i].Promedio();
                    nombre = Estudiante[i].RetornarNombre();
                }   
            }

            Console.WriteLine("El alumno con mejor promedio es: " + nombre);
        }

        public void reprobados()
        {
            Console.WriteLine("Alumnos con alguna nota desaprobada:");

            for (int i = 0; i < 3; i++)
            {
                if (Estudiante[i].Desaprobado())
                {
                    Console.WriteLine(Estudiante[i].RetornarNombre());
                }
            }
        }

        public void Escuela()
        {
            Promedios();
            MejorPromedio();
            reprobados();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Curso C = new Curso();

            C.Escuela();
        }
    }
}
