using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Vectores
    {
        
        //1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        //El valor acumulado de todos los elementos del vector.
        //El valor acumulado de los elementos del vector que sean mayores a 36.
        //Cantidad de valores mayores a 50.
        private int[] valores;
        private int suma = 0;
        private int dato = 1;
        private int Mayores36 = 0;
        private int Mayores50 = 0;
        public void Inicio()
        {
            valores = new int[8];
            Console.WriteLine("escriva 8 digitos");
            string Linea;
            for (int i = 0; i < 8; i++) 
            { 
                Console.Write("digito N° "+ dato + ": ");
                Linea = Console.ReadLine();
                valores[i] = int.Parse(Linea);

                dato = dato + 1;
            }



        }

        public void Suma()
        {
            for (int i = 0;i < 8; i++)
            {
                if (valores[i] >= 36 && valores[i] <50)
                {
                    
                    Mayores36++;
                }

                if (valores[i] >= 50)
                {

                    Mayores50++;
                }
                suma = suma +  valores[i];
            }
        }

        public void Mostrar_Datos()
        {
            Suma();
           
            Console.WriteLine("Loca vectores sumados son igual a: " + suma);
            
           
            Console.WriteLine("los numeros mayores a 36 y menores a 50 Son: ");
            Console.WriteLine(Mayores36);

            Console.WriteLine("los numeros mayores a 50 son: ");
            Console.WriteLine(Mayores50);
        }

        static void Main(string[] args)
        {
            Vectores Vec = new Vectores();
            Vec.Inicio();
            Vec.Mostrar_Datos();
            
        }
    }
}
