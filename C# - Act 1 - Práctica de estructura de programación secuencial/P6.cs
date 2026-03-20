using System;

class Program
{
    static void Main()
    {
        double peso, altura, imc;

        Console.WriteLine("Peso:");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura:");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / (altura * altura);

        Console.WriteLine("IMC: " + imc);
    }
}