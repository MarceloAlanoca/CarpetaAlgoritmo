using System;

namespace Punto1
{
    internal class Calculo
    {
        public int y, x, cuadrante;
        public String Linea;

        public void Iniciar()
        {
            Console.WriteLine("Ingrese coordenas 'y' y 'x' ");
            Console.Write("Coordenada y: ");
            Linea = Console.ReadLine();
            y = int.Parse(Linea);

            Console.Write("Coordenada x: ");
            Linea = Console.ReadLine();
            x = int.Parse(Linea);

        }

        public String Cuadrante()
        {
            if (y > 0 && x > 0)
            {
                return "estas en el primer cuadrante";

            }

            else if (x < 0 && y > 0)
            {
                return "estas en el segundo cuadrante";
            }

            else if (x < 0 && y < 0)
            {
                return "estas en el tercer cuadrante";

            }
            else if (x > 0 && y < 0)
            {
                return "estas en el cuarto cuadrante";

            }
            else
                return "estas sobre un eje";
        }

        public void MostrarCuadrante()
        {
            string resultado = Cuadrante();
            Console.WriteLine(resultado);
        }

        static void Main(string[] args)
        {
            Calculo calculo1 = new Calculo();
            calculo1.Iniciar();
            calculo1.Cuadrante();
            calculo1.MostrarCuadrante();


            Console.ReadKey();
        }
    }
}
