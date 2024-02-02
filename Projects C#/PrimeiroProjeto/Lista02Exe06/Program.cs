using System;
/* Ler um numero e verificar se está entre intevalos pre definidos */
namespace Lista02Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu número:...");
            int x = int.Parse(Console.ReadLine());


            if (x > 0 ) { 
                for (int i = 0; i < 25; i++)
                {
                    int a = i;
                    if (x == a)
                    {
                        Console.WriteLine($"Seu Número {x} está entre 0 e 25 ");
                    }
                }

                for (int i = 25; i < 50; i++)
                {
                    int a = i;
                    if (x == a)
                    {
                        Console.WriteLine($"Seu Número {x} está entre 25 e 50 ");
                    }
                }
                for (int i = 50; i < 75; i++)
                {
                    int a = i;
                    if (x == a)
                    {
                        Console.WriteLine($"Seu Número {x} está entre 50 e 75 ");
                    }
                }
                for (int i = 75; i < 100; i++)
                {
                    int a = i;
                    if (x == a)
                    {
                        Console.WriteLine($"Seu Número {x} está entre 75 e 100 ");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Seu número é {x} e está fora dos Intervalos entre 0 e 100 !");
            }


        }
    }
}