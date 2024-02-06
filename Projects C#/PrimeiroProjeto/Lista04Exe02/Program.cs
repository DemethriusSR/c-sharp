using System;
/* Teste */
namespace Lista04Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1,contIN = 0, contOut = 0;

            while (x > 0)
            {
                Console.WriteLine("Escreva numeros maiores que zero: ");
                x = int.Parse(Console.ReadLine());
                    if ((x >= 10) || (x <= 20))
                    {
                        contIN++;
                    }
                    else
                    {
                        contOut++;
                    }
            }
            Console.WriteLine($"IN 10 e 20: {contIN}");
            Console.WriteLine($"OUT 10 e 20: {contOut}");

        }
    }
}