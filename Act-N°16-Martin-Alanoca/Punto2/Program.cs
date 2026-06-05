using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
         2. Plantear una clase Producto y otra clase Inventario.
            La clase Producto debe tener como atributos privados el nombre, precio y
            stock. Definir propiedades para acceder a estos atributos, asegurando que el
            stock no pueda ser negativo y el precio sea mayor a cero.
            La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
            método para mostrar todos los productos ordenados de menor a mayor en
            base al precio, además, mostrar el producto más caro y más barato del
            inventario.
     */
    class Producto
    {
        private string nombre;
        private float precio;



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
        public float Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }
        public Producto()
        {
            String Linea;
            Console.Write("nombre del Producto: ");
            Linea = Console.ReadLine();
            nombre = Linea;

            Console.Write("-->precio del produto: ");
            Linea = Console.ReadLine();
            precio = float.Parse(Linea);

            Console.WriteLine();
        }
        public string VerifcarPrecio()
        {
            if (precio > 0)
            {
                string Mensaje = "Precio acorde con la informacion";
                return Mensaje;
            }
            else
            {
                string Mensaje = "El precio no puedo ser menor a 0";
                return Mensaje;
            }
        }
    }
    class Stock 
    {

        private Producto[] Producto;
        public Stock ()
        {
            Producto = new Producto[3];
            for (int i = 0; i < Producto.Length; i++)
            {
                Producto[i] = new Producto();
            }

        }
        public void Order()
        {
            float aux = 0;
            for (int i = 0;i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (Producto[i].Precio > Producto[j].Precio)
                    {
                        Producto[i].Precio = aux;

                    }
                }
            }
        }

        public void ImprimirStock()
        {
            for (int i = 0; i < Producto.Length; i++)
            {
                Console.WriteLine($"nombre del producto: {Producto[i].Nombre} y su precio es: {Producto[i].Precio}");
            }

        }
    }
    internal class Tienda
    {
        static void Main(string[] args)
        { 
            Stock Stocke = new Stock();
                    
            Console.WriteLine("---Cargando Datos---");
            Stocke.ImprimirStock();
            
                
                
            Console.ReadKey();
                
        }
    }    
    
}
