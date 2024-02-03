using System;
using System.Globalization;
/* Teste */
namespace Lista03Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            do
            {
                Console.Write("Eixo X: ");
                x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Eixo Y: ");
                y = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("\n");

                if ((x > 0) && (y > 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está em PRIMEIRO");
                    }
                    else if ((x < 0) && (y > 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está em SEGUNDO");
                    }
                    else if ((x < 0) && (y < 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está em TERCEIRO");
                    }
                    else if ((x > 0) && (y < 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está em QUARTO");
                    }
                   
            }while((x != 0) || (y != 0));
        }
    }
}
            