using System;
using System.Globalization;
/* Trabalhando com Vetores */
namespace ExeFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de posições: ");
            int n = int.Parse(Console.ReadLine());

            Product [] vet = new Product[n];

            Console.WriteLine("Insira os dados do Produto nome | preço: ");

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product { Name = name, Price = preco };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vet[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine($"Média = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}