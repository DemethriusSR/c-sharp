using System;
/* Calcular divisores */
namespace Lista04Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero: ");
            int num = int.Parse(Console.ReadLine());

            try
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($" Divisores = {i}");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}