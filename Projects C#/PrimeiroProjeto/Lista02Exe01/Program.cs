using System;
/* Digitar um numero e mostrar se e negativo ou não */
namespace Lista02Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero:... ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 < 0) {
                Console.WriteLine($" NEGATIVO ! {num1}");
            }
            else if (num1 >= 0) {
                Console.WriteLine($" POSITIVO {num1}");
            }
            else {
                Console.WriteLine(" NUMERO INVALIDO !");
            }
            
        }

    }
}

