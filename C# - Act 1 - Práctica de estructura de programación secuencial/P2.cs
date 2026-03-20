using System;

class Program
{
    static void Main()
    {
        double n1, n2, n3, n4;

        Console.WriteLine("Ingrese 4 numeros:");
        n1 = Convert.ToDouble(Console.ReadLine());
        n2 = Convert.ToDouble(Console.ReadLine());
        n3 = Convert.ToDouble(Console.ReadLine());
        n4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Suma: " + (n1 + n2));
        Console.WriteLine("Producto: " + (n3 * n4));
    }
}