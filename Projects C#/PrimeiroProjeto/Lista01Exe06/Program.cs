using System;
using System.Globalization;
/* Calcula area de diversas formas geometricas */
namespace Lista01Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1:... ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor 1:... ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor 1:... ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = (a * c) / 2;
            double circulo = pi * (Math.Pow(c,2));
            double trapezio = ((a + b)*c) / 2;
            double quadrado = Math.Pow(b,2);
            double retangulo = a * b;


            Console.WriteLine("#######################################");
            Console.WriteLine($"#  Triangulo = {triangulo.ToString("F2")}      #");
            Console.WriteLine($"#  Circulo   = {circulo.ToString("F2")}      #");
            Console.WriteLine($"#  Trapezio  = {trapezio.ToString("F2")}      #");
            Console.WriteLine($"#  Quadrado  = {quadrado.ToString("F2")}      #");
            Console.WriteLine($"#  Retangulo = {retangulo.ToString("F2")}      #");
            Console.WriteLine("#######################################");
            Console.ReadKey();
        }

    }
}


