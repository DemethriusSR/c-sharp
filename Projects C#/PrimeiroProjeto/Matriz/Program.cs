using System;
/* Utilizando Matriz */
namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] data = new double[2, 3];

            Console.WriteLine($"Matriz 2 x 3, {data.Length} elementos");
            Console.WriteLine($"Linhas {data.Rank}");
            Console.WriteLine($"linhas {data.GetLength(0)}");
            Console.WriteLine($"Colunas {data.GetLength(1)}");
        }
    }
}