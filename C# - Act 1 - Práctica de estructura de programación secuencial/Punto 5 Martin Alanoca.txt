using System;

class Program
{
    static void Main()
    {
        double radio;
        double area, circunferencia;

        Console.WriteLine("Ingrese radio:");
        radio = Convert.ToDouble(Console.ReadLine());

        circunferencia = 2 * Math.PI * radio;
        area = Math.PI * radio * radio;

        Console.WriteLine("Circunferencia: " + circunferencia);
        Console.WriteLine("Area: " + area);
    }
}