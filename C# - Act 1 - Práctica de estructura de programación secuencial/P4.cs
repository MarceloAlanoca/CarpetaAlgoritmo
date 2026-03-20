using System;

class Program
{
    static void Main()
    {
        double precio;
        int cantidad;
        double total;

        Console.WriteLine("Precio:");
        precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Cantidad:");
        cantidad = Convert.ToInt32(Console.ReadLine());

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: " + total);
    }
}