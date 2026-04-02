using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Realizar un programa que lea los lados de n triángulos, e informar:
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            //iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.//


            int lado1,
                lado2,
                lado3,
                valor,
                cont_escaleno,
                cont_isoceles,
                cont_equilatero,
                cant;
               
            String Linea;
            cont_equilatero = 0;
            cont_escaleno = 0;
            cont_isoceles = 0;
           

            Console.WriteLine("Ingrese la cantidad de triangulos que quieres calcular");
            Linea = Console.ReadLine();
            cant = int.Parse(Linea);

            for (int i = 0; i < cant; i++)
            {
                

                    Console.WriteLine("Ingrese los 3 datos para calcular el triangulo");

                    valor = int.Parse(Linea);
                    if (valor > 0)
                    {

                        Console.WriteLine("1° lado: ");
                        Linea = Console.ReadLine();
                        lado1 = int.Parse(Linea);

                        Console.WriteLine("2° lado: ");
                        Linea = Console.ReadLine();
                        lado2 = int.Parse(Linea);

                        Console.WriteLine("3° lado: ");
                        Linea = Console.ReadLine();
                        lado3 = int.Parse(Linea);


                        if (lado1 == lado2 && lado2 == lado3)
                        {

                            Console.WriteLine("Es un triangulo equilatero\n" + lado1 + "\n" + lado2 + "\n" + lado3);
                            cont_equilatero++;

                        }

                        if ((lado1 == lado2 && lado1 != lado3) || (lado2 == lado3 && lado2 != lado1) || (lado1 == lado3 && lado1 != lado2))
                        {
                            Console.WriteLine("Es un triangulo isoceles\n" + lado1 + "\n" + lado2 + "\n" + lado3);
                            cont_isoceles++;
                        }
                        if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                    {

                            Console.WriteLine("Es un triangulo escaleno\n" + lado1 + "\n" + lado2 + "\n" + lado3);
                            cont_escaleno++;

                        }
                    
                    
                    }
            }

            Console.WriteLine("la cantidad de triagunlos equilatero registraron fueron: " + cont_equilatero);
            Console.WriteLine("la cantidad de triagunlos escaleno registraron fueron: " + cont_escaleno);
            Console.WriteLine("la cantidad de triagunlos isoceles registraron fueron: " + cont_isoceles);

            if (cont_equilatero < cont_isoceles && cont_equilatero < cont_escaleno){
                Console.WriteLine("la cantidad con menos triangulos son los equilateros y son: " + cont_equilatero);
            }

            if (cont_isoceles < cont_equilatero && cont_isoceles < cont_escaleno)
            {
                Console.WriteLine("la cantidad con menos triangulos son los isoceles y son: " + cont_isoceles);
            }
            if (cont_escaleno < cont_equilatero &&  cont_escaleno < cont_isoceles)
            {
                Console.WriteLine("la cantidad con menos triangulos son los escalenos y son: " + cont_escaleno);
            }
            Console.ReadKey();
        }
    }
}
