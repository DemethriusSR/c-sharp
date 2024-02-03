using System;
using System.Globalization;
/* Mostra quadrante do plano cartesiano de acordo com numero do usuário */
namespace Lista03Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            bool val = false;

            while (val == false)
            {
                Console.Write("Eixo X: ");
                x = int.Parse(Console.ReadLine());
                
                Console.Write("Eixo Y: ");
                y = int.Parse(Console.ReadLine());

                Console.Write("\n");

                    if ((x > 0) && (y > 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está no PRIMEIRO \n");
                        val = false;
                    }
                    else if ((x < 0) && (y > 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está no SEGUNDO \n");
                        val = false;
                    }
                    else if ((x < 0) && (y < 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está no TERCEIRO \n");
                        val = false;
                    }
                    else if ((x > 0) && (y < 0))
                    {
                        Console.WriteLine($"Coordenadas x = {x} e y = {y} está no QUARTO \n");
                        val = false;
                    }
                    else if ((x != 0) || (y != 0))
                    {
                        Console.WriteLine("SAINDO DA TELA... ");
                    val = true;
                    }
            }
        }
    }
}
            