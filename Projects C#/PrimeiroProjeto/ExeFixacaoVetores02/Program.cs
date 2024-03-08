using System;
using System.Globalization;
/* Trabalhando com Vetores */
namespace ExeFixacaoVetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Cliente [] cliente = new Cliente[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                int numQuarto = int.Parse(Console.ReadLine());
                cliente [numQuarto] = new Cliente { Name = name, Email = email };
            }

            for (int i = 0;i < cliente.Length;i++) {
                Console.WriteLine($" Nome: {cliente[i].Name} " +
                    $"e-mail: {cliente[i].Email}" +
                    $" Room {i}");

            }

    }
}