using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /*
     Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
    ● Implementar propiedades y un constructor que cargue valores.
    ● Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    nombre en pantalla y Console.CursorVisible para ocultar el cursor.
    ● Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    consola.
     */
    class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;

        public string Nombre
        {
            set 
            { 
                nombre = value; 
            }
            get 
            { 
                return nombre; 
            }
        }

        public int PosX
        { 
            set 
            { 
                posX = value; 
            }
            get 
            { 
                return posX; 
            }
        }

        public int PosY
        {
            set 
            { 
                posY = value; 
            }
            get 
            { 
                return posY; 
            }
        }

        public ElementoPantalla(string nombre, int x, int y)
        {
            this.nombre = nombre;
            this.posX = x;
            this.posY = y;
        }

        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(posX, posY);
            Console.Write(Nombre);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];
            for (int i = 0; i < elementos.Length; i++)
            {
                Console.Clear();

                Console.WriteLine("Elemento " + (i + 1));

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Posicion en X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Posicion en Y: ");
                int y = int.Parse(Console.ReadLine());

                elementos[i] = new ElementoPantalla(nombre, x, y);
            }

            Console.Clear();

            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i].Mostrar();
            }

            Console.SetCursorPosition(0, 20);
            Console.CursorVisible = true;

            Console.ReadKey();
        }
    }
}
