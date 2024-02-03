using System;
using System.ComponentModel.DataAnnotations;
/* Teste */
namespace Lista03Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            bool valida = false;

            do
            {
                Console.Write("Sua senha ? ");
                int x = int.Parse(Console.ReadLine());
                if (x!= senha){
                    valida = false;
                }
                else
                {
                    valida = true;
                }
            } while (valida != true);
            Console.WriteLine("ACESSO PERMITIDO !");

        }
    }
}