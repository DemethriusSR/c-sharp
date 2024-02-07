using System;
/* Calcular fatorial */
namespace Lista04Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número: ");
            int num = int.Parse(Console.ReadLine());
            int res = 1;

            for (int i = 1; i <= num; i++)
             {
                res = res * i;
             }
                Console.WriteLine($" FATORIAL de {num} = {res}");
        }
    }
}
