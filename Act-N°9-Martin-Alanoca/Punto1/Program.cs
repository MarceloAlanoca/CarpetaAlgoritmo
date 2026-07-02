using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        /*
        Se desea desarrollar un programa que permita registrar los nombres y las
        calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.
        */
        private string[] Alumnos;
        private int[] Notas;
        public void Inicio()
        {
            Alumnos = new string[6];
            Notas = new int[6];
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del alumno: ");
                Alumnos[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del alumno: ");
                string notaingresada;
                notaingresada = Console.ReadLine();
                Notas[i] = int.Parse(notaingresada);
            }
        }
        public void NA_NB()
        {
            string alumno_destacado = Alumnos[0];
            int Nota_Alta = Notas[0];
            string alumno_mediocre = Alumnos[0];
            int Nota_Baja = Notas[0];
            int NotasMax = 0;
            int NotasMin = 0;
            for (int i = 0; i < Alumnos.Length; i++)
            {
                if (Notas[i] > Nota_Alta)
                {
                    Nota_Alta = Notas[i];
                    alumno_destacado = Alumnos[i];
                }
                if (Notas[i] < Nota_Baja)
                {
                    Nota_Baja = Notas[i];
                    alumno_mediocre = Alumnos[i];
                }
            }
            for (int i = 0; i < Alumnos.Length; i++)
            {
                if (Nota_Alta == Notas[i])
                {
                    NotasMax++;
                }
                if (Nota_Baja == Notas[i])
                {
                    NotasMin++;
                }
            }
            Console.WriteLine("El alumno con la nota más alta es: " + alumno_destacado + (" con: ") + Nota_Alta);
            Console.WriteLine("El alumno con la nota más baja es: " + alumno_mediocre + (" con: ") + Nota_Baja);
            if (NotasMax > 1)
            {
                Console.WriteLine("La nota alta entre los alumnos se repite: " + NotasMax);
            }
            else
            {
                Console.WriteLine("La nota alta no se repite");
            }
            if (NotasMin > 1)
            {
                Console.WriteLine("La nota baja entre los alumnos se repite: " + NotasMin);
            }
            else
            {
                Console.WriteLine("La nota baja no se repite");
            }
            Console.ReadKey();
        }
        public void mostrardatos()
        {
            Inicio();
            NA_NB();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mostrardatos();
        }

    }
}

