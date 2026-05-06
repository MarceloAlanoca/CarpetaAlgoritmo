using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            //cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            //finalizar al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            //informe:
            //a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            //que:
            //Estado de la cuenta:
            //○ “Acreedor” si el saldo es &gt; 0.
            //○ “Deudor” si el saldo es &lt; 0.
            //○ “Nulo” si el saldo es = 0.
            //b) La suma total de los saldos acreedores.


            int valor, dinero;
            int sumaAcreedores = 0;
            string Linea;
            Console.WriteLine("Ingrese datos");

            do
            {
                Console.WriteLine("Numero de cuenta:");
                Linea = Console.ReadLine();
                valor = int.Parse(Linea);

                if (valor >= 0)
                {
                    Console.WriteLine("Saldo de cuenta:");
                    Linea = Console.ReadLine();
                    dinero = int.Parse(Linea);

                    if (dinero > 0)
                    {
                        Console.WriteLine("Cuenta: " + valor + " - Estado: Acreedor");
                        sumaAcreedores += dinero;
                    }
                    else if (dinero < 0)
                    {
                        Console.WriteLine("Cuenta: " + valor + " - Estado: Deudor");
                    }
                    else
                    {
                        Console.WriteLine("Cuenta: " + valor + " - Estado: Nulo");
                    }
                }

            } while (valor >= 0);

            Console.WriteLine("Total de saldos acreedores: " + sumaAcreedores);
            Console.ReadKey();
        }
    }
}
