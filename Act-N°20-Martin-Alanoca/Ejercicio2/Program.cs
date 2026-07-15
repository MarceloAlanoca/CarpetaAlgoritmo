using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Paquete
    {
        /*
            Problema:
                Una empresa de envíos desea registrar sus entregas mediante colaboración de
                clases.
                Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
                Despachador que contenga una lista de paquetes y un método para registrar nuevos
                paquetes.
                Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
                 Todos los paquetes registrados.
                 Cuántos superan los 10 kg de peso.
                 Cuántos tienen destino nacional (por ejemplo, “Argentina”). 

         */
        private int codigo;
        private int peso;
        private string destino;
        public int Codigo
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
        public int Peso
        {
            set
            {
                peso = value;
            }
            get
            {
                return peso;
            }
        }
        public string Destino
        {
            set 
            { 
                destino = value; 
            }
            get
            {
                return destino;
            }
        }
    }
    class Despachador
    {
        public List<Paquete> paquetes = new List<Paquete>();

        public void RegistrarPaquete(Paquete p)
        {
            paquetes.Add(p);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Despachador despachador = new Despachador();

            for (int i = 0; i < 5; i++)
            {
                Paquete paquete = new Paquete();

                Console.Write("Código del paquete: ");
                paquete.Codigo = int.Parse(Console.ReadLine());

                Console.Write("Peso del paquete(KG): ");
                paquete.Peso = int.Parse(Console.ReadLine());

                Console.Write("Destino del paquete: ");
                paquete.Destino = Console.ReadLine();

                despachador.RegistrarPaquete(paquete);

                Console.WriteLine();
            }

            int masDe10Kg = 0;
            int nacionales = 0;

            Console.WriteLine("--- Paquetes Registrados ---");

            foreach (Paquete p in despachador.paquetes)
            {
                Console.WriteLine("Código: " + p.Codigo);
                Console.WriteLine("Peso: " + p.Peso + " kg");
                Console.WriteLine("Destino: " + p.Destino);
                Console.WriteLine();

                if (p.Peso > 10)
                { 
                    masDe10Kg++; 
                }

                if (p.Destino.ToLower() == "nacional")
                {
                    nacionales++;
                }
            }

            Console.WriteLine("Paquetes con más de 10 kg: " + masDe10Kg);
            Console.WriteLine("Paquetes con destino nacional: " + nacionales);
            Console.ReadKey();
        }
    }
}
