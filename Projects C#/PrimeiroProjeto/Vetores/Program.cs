using System;
using System.Globalization;
/* Trabalhando com Vetores */
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de posições: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for(int i = 0;i < n; i++) {
                sum += vet[i];
            }

            double avg = sum / n;
            Console.WriteLine($"Média = {avg.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}