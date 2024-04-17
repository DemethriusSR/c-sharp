using System;
/* Exercicio Fixação Matriz */
namespace ExeFixacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Quantos elementos");
                int n = int.Parse(Console.ReadLine());

                int count = 0;

                int[,] matriz = new int[n, n]; //Declarando a Matriz

                for (int i = 0; i < n; i++)
                {
                    string[] values = Console.ReadLine().Split(' '); //Leitura dos valores da linha

                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = int.Parse(values[j]);
                    }
                }


                Console.WriteLine("------ Linha Diagonal da Matriz ------");
                for (int i = 0; i < n; i++)
                {
                   Console.Write($" | {matriz[i, i]} ");
                }
                Console.WriteLine();
                Console.WriteLine(" ------------------------- ");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++) 
                    { 
                        if (matriz[i, j] < 0)
                        {
                            count++;
                            
                        }
                    }
                }
                Console.WriteLine($" {count} números negativos.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}