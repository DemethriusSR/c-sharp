using System;
using System.Globalization;
/* Ler valores X e Y e veja em qual quadrante está as coordenadas */
namespace Lista02Exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eixo X: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Eixo Y: ");
            Console.Write("\n");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((x > 0) && (y > 0))
            {
                Console.WriteLine($"Coordenadas x = {x:F1} e y = {y:F1} está em Q1");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine($"Coordenadas x = {x:F1} e y = {y:F1} está em Q2");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine($"Coordenadas x = {x:F1} e y = {y:F1} está em Q3");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine($"Coordenadas x = {x:F1} e y = {y:F1} está em Q4");
            }
            else if ((x == 0) && (y == 0))
            {
                Console.WriteLine($"Coordenadas x = {x:F1} e y = {y:F1} está na ORIGEM");
            }
        }
    }
}