using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.


            int num,
                valor,
                Cont_positivos,
                Cont_negativos,
                Cont_pares,
                Cont_Multiplos;
            string linea;
            num = 10;
            Cont_Multiplos = 0;
            Cont_negativos = 0;
            Cont_positivos = 0;
            Cont_pares = 0;

            Console.WriteLine("ingrse 10 numeros en la consola");
            

            for (int i = 0; i < num; i++) {

                
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor > 0) { 
                    Cont_positivos++;
                }
                if(valor < 0) {
                    Cont_negativos++;
                }
                if(valor % 2 == 0) {
                    Cont_pares++;
                }
                if(valor % 15 == 0) {
                    Cont_Multiplos++;
                }

            }
            Console.WriteLine("La cantidad de numeros positivos ingresados fueron: " + Cont_positivos);
            Console.WriteLine("La cantidad de numeros negativos ingresados fueron: " + Cont_negativos);
            Console.WriteLine("La cantidad de numeros pares ingresados fueron: " + Cont_pares);
            Console.WriteLine("La cantidad de numeros multiplos de 15 igresado fueron: " + Cont_Multiplos);

            Console.ReadKey();
        }
    }
}
