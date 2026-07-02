using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
        Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.
    */
    internal class Program
    {
        private string[] Atletas;
        private int[] Tiempos;
        public void Inicio()
        {
            Atletas = new string[5];
            Tiempos = new int[5];
            for (int i = 0; i < Atletas.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del atleta: ");
                Atletas[i] = Console.ReadLine();
                Console.WriteLine("Ingresa su tiempo total: ");
                string valor;
                valor = Console.ReadLine();
                Tiempos[i] = int.Parse(valor);
            }
        }
        public void TierList()
        {
            double suma = 0;
            double tiempopromedio = 0;
            int mejortiempo = Tiempos[0];
            string mejoratleta = Atletas[0];
            int peortiempo = Tiempos[0];
            string peoratleta = Atletas[0];
            for (int i = 0; i < Tiempos.Length; i++)
            {
                if (Tiempos[i] < mejortiempo)
                {
                    mejortiempo = Tiempos[i];
                    mejoratleta = Atletas[i];
                }
                if (Tiempos[i] > peortiempo)
                {
                    peortiempo = Tiempos[i];
                    peoratleta = Atletas[i];
                }

                suma = suma + Tiempos[i];
            }
            tiempopromedio = suma / Tiempos.Length;
            Console.WriteLine("El tiempo promedio es de: " + tiempopromedio + " segundos!");
            Console.WriteLine("El atleta con mejor tiempo es: " + mejoratleta + " con el tiempo de: " + mejortiempo);
            Console.WriteLine("El atleta con peor tiempo es: " + peoratleta + " con el tiempo de: " + peortiempo);

            for (int i = 0; i < Tiempos.Length; i++)
            {
                if (Tiempos[i] < tiempopromedio)
                {
                    Console.WriteLine("El Atleta " + Atletas[i] + " superó el tiempo promedio");
                }
            }
        }
        public void MostrandoValores()
        {
            Inicio();
            TierList();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MostrandoValores();
        }
    }
}
