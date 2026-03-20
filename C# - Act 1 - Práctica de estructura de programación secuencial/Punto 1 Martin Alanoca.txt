using System;

class Program
{
    static void Main()
    {
        string linea;
        int lado, perimetro;

        Console.Write("Ingrese el lado: ");
        linea = Console.ReadLine();
        lado = int.Parse(linea);

        perimetro = lado * 4;

        Console.Write("El perimetro es: ");
        Console.WriteLine(perimetro);

        Console.ReadKey();
    }
}