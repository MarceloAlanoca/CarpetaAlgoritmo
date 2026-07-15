using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /*
     Problema:
        Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
        arqueológicas durante 4 semanas.
        Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
        días. Luego:
         Calcular el total de visitas por zona y almacenarlo en un vector.
         Mostrar los datos en forma tabular.
         Agregar estos resultados a una lista llamada zonasVisitadas que contenga
        nombres de zonas y total de visitas.
         Determinar cuál fue la zona más visitada.
     */
    class ZonasVisitada
    {
        private string nombreZona;
        private int totalVisitas;
        public string NombreZona
        {
            set
            {
                nombreZona = value;
            }
            get
            {
                return nombreZona;
            }
        }
        public int TotalVisitas
        {
            set
            {
                totalVisitas = value;
            }
            get
            {
                return totalVisitas;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] visitas = new int[3, 4];
            int[] totalZona = new int[3];

            string[] nombres = { "Zona A", "Zona B", "Zona C" };
            List<ZonasVisitada> zonavi = new List<ZonasVisitada>();
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("Ingrese las visitas de " + nombres[f]);

                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Semana " + (c + 1) + ": ");
                    visitas[f, c] = int.Parse(Console.ReadLine());

                    totalZona[f] += visitas[f, c];
                }

                Console.WriteLine();
            }
            Console.WriteLine("\nTabla de visitas");
            Console.Write("\tS1\tS2\tS3\tS4\tTotal");

            for (int f = 0; f < 3; f++)
            {
                Console.Write("\n" + nombres[f] + "\t");

                for (int c = 0; c < 4; c++)
                {
                    Console.Write(visitas[f, c] + "\t");
                }

                Console.Write(totalZona[f]);
            }
            for (int i = 0; i < 3; i++)
            {
                ZonasVisitada zona = new ZonasVisitada();
                zona.NombreZona = nombres[i];
                zona.TotalVisitas = totalZona[i];

                zonavi.Add(zona);
            }

            Console.WriteLine("\n\nLista de zonas visitadas");

            foreach (ZonasVisitada z in zonavi)
            {
                Console.WriteLine(z.NombreZona + " - " + z.TotalVisitas + " visitas");
            }
            ZonasVisitada mayor = zonavi[0];

            foreach (ZonasVisitada z in zonavi)
            {
                if (z.TotalVisitas > mayor.TotalVisitas)
                {
                    mayor = z;
                }
            }

            Console.WriteLine("\nLa zona más visitada fue: " + mayor.NombreZona + " con " + mayor.TotalVisitas + " visitas.");
        }
    }
}
