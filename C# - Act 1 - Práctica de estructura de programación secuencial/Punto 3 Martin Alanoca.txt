using System;

class Program
{
    static void Main()
    {
        double n1, n2, n3, n4;
        double suma, promedio;

        Console.WriteLine("Ingrese 4 numeros:");
        n1 = Convert.ToDouble(Console.ReadLine());
        n2 = Convert.ToDouble(Console.ReadLine());
        n3 = Convert.ToDouble(Console.ReadLine());
        n4 = Convert.ToDouble(Console.ReadLine());

        suma = n1 + n2 + n3 + n4;
        promedio = suma / 4;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}