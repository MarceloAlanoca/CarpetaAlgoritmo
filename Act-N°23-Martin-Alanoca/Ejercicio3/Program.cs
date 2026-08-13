using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /*
        Un centro de conservación marina registra de forma dinámica las especies de
        mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
         Crear la clase MonitoreoCostero que contenga como atributo privado
        una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
         Métodos en MonitoreoCostero:
        1. CargarAvistamientos(): Solicitar por teclado nombres de
        especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
        &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
        cuando el usuario ingresa la palabra &quot;FIN&quot;.
        2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
        organizada alfabéticamente de la A a la Z utilizando el método
        .Sort().
        3. MostrarReporteInvertido(): Imprimir la lista organizada de la
        Z a la A combinando .Sort() con el método .Reverse().
        4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
        animal y, utilizando los métodos de búsqueda de listas, informar si la
        especie fue divisada en la costa durante el día.
     */
    internal class MonitoreoCostero
    {
        private List<string> especiesDetectadas = new List<string>();

        public void CargaAvistamientos() 
        {
            String Mamifero;
            Console.WriteLine("Ingrese nombres de especies marinas:");
            do
            {
                Console.Write("-->");
                Mamifero = Console.ReadLine();

                if (Mamifero != "FIN")
                {
                    especiesDetectadas.Add(Mamifero);
                }
            }
            while (Mamifero != "FIN");
            Console.WriteLine();
        }
        public void MostrandoReporteOrdenado()
        {
            Console.WriteLine("=== MOSTRANDO LISTA ORDENADA DE A-Z");
            especiesDetectadas.Sort();
            foreach (var item in especiesDetectadas) 
            { 
                Console.WriteLine("-->" + item); 
            }
            Console.WriteLine();
        }
        public void MostrarReporteInvertido()
        {
            Console.WriteLine("=== MOSTRANDO LISTA INVERTIDA DE Z-A");
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            foreach (var item in especiesDetectadas)
            {
                Console.WriteLine("-->" + item);
            }
            Console.WriteLine();
        }
        public void BuscarEspecie()
        {
            Console.Write("Ingrese el nombre del mamifero que quiere buscar: ");
            string Mamifero = Console.ReadLine();

            if (especiesDetectadas.Contains(Mamifero))
            {
                Console.WriteLine("El mamifero marino fue encontrado");
            }
            else
            {
                Console.WriteLine("El mamifero marino no fue encontrado");
            }
        }
        static void Main(string[] args)
        {
            MonitoreoCostero MC = new MonitoreoCostero();
            MC.CargaAvistamientos();
            MC.MostrandoReporteOrdenado();
            MC.MostrarReporteInvertido();
            MC.BuscarEspecie();
            Console.ReadKey();
        }
    }
}
