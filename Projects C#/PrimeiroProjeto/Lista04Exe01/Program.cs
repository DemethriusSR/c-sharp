using System;
/* Usuário digita um numero e o programa mostra numeros IMPARES */
namespace Lista04Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha seu numero para ver QTD de Impares entre eles: ");
            int x = int.Parse(Console.ReadLine());
                    
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine($"{i}\n");
                    }
                }
        }
    }
}