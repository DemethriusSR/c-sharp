using System;
/* Digitar um numero e mostrar se e multiplo entre si */
namespace Lista02Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero:... ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um numero:... ");
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 % num2 == 0) || (num2 % num1 == 0))
            {
                Console.WriteLine($" MULTIPLO !");
            }
            else 
            {
                Console.WriteLine($" NAO MULTIPLOS !");
            }

        }

    }
}


