using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class RobotEnsamblador
    {
        private string ModeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

            Console.Write("Ingrese el modelo del robot: ");
            ModeloRobot = Console.ReadLine();

            tiemposOperacion = new float[4][];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Cantidad de subtareas en la fase {fases[i]}: ");
                int cantidad = int.Parse(Console.ReadLine());

                tiemposOperacion[i] = new float[cantidad];

                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write($"Tiempo de la subtarea {j + 1} (segundos): ");
                    tiemposOperacion[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }

        public string GetModeloRobot()
        {
            return ModeloRobot;
        }

        public float[][] GetTiemposOperacion()
        {
            return tiemposOperacion;
        }
    }

    class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;

        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCargando robot {i + 1}");
                robots[i] = new RobotEnsamblador();
            }
        }

        public void ReporteTiempos()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

            Console.WriteLine("Reporte de tiempos: ");

            foreach (var robot in robots)
            {
                Console.WriteLine($"\nRobot: {robot.GetModeloRobot()}");

                float[][] tiempos = robot.GetTiemposOperacion();

                for (int i = 0; i < tiempos.Length; i++)
                {
                    Console.WriteLine($"Fase: {fases[i]}");

                    for (int j = 0; j < tiempos[i].Length; j++)
                    {
                        Console.WriteLine($"  Subtarea {j + 1}: {tiempos[i][j]} segundos");
                    }
                }
            }
        }

        public void RobotMasEficiente()
        {
            string mejorRobot = "";
            float mejorPromedio = float.MaxValue;

            foreach (var robot in robots)
            {
                float[][] tiempos = robot.GetTiemposOperacion();

                float suma = 0;
                int cantidadTareas = 0;

                for (int i = 0; i < tiempos.Length; i++)
                {
                    for (int j = 0; j < tiempos[i].Length; j++)
                    {
                        suma += tiempos[i][j];
                        cantidadTareas++;
                    }
                }

                float promedio = suma / cantidadTareas;

                Console.WriteLine($"Promedio de {robot.GetModeloRobot()}: {promedio:F2} segundos");

                if (promedio < mejorPromedio)
                {
                    mejorPromedio = promedio;
                    mejorRobot = robot.GetModeloRobot();
                }
            }

            Console.WriteLine("Robot más eficiente: ");
            Console.WriteLine(
                $"{mejorRobot} con un promedio de {mejorPromedio:F2} segundos por operación.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PlantaIndustrial p = new PlantaIndustrial();

            p.ReporteTiempos();
            p.RobotMasEficiente();
        }
    }
}
