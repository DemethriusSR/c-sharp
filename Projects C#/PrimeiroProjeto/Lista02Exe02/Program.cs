using System;
/* Digitar um numero e mostrar se e Par ou Impar */
namespace Lista02Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero:... ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($" PAR ! {num1}");
            }
            else
            {
                Console.WriteLine($" IMPAR {num1}");
            }
        }

    }
}


