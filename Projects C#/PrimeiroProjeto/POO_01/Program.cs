using System;
using System.Globalization;
/* Calcular area de dois triangulos sem POO */
namespace POO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.Write("Entre com medidas do triangulo X: ");
            xA = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com medidas do triangulo y: ");
            yA = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.Write($"Area X = {areaX:F4} \n");
            Console.Write($"Area Y = {areaY:F4} \n");
            bool maior = (areaX > areaY);
                if (maior == true)
                {
                    Console.Write("Maior Area é X");
                }
                else
                {
                    Console.Write("Maior é Y");
                }

        }
    }
}