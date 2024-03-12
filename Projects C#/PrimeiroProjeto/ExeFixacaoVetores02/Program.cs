using System;
using System.Globalization;
/* Trabalhando com Vetores */
namespace ExeFixacaoVetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Cliente[] cliente = new Cliente[10];
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Quantos quartos serão alugados: ");
                int n = int.Parse(Console.ReadLine());


                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome, e-mail e numero do quarto ?");
                Console.WriteLine("----------------------------------");

                

                for (int i = 1; i <= n; i++)
                {
                    string name = Console.ReadLine();
                    string email = Console.ReadLine();
                    int numQuarto = int.Parse(Console.ReadLine());
                    cliente[numQuarto] = new Cliente (name, email);
                    Console.WriteLine("----------------------------------");
                }

                Console.WriteLine("----------------------------------");

                for (int i = 1; i < 10; i++)
                {
                    if (cliente[i] != null)
                    {
                        Console.WriteLine(i + " : " + cliente[i]);
                    }
                }

                Console.WriteLine("----------------------------------");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}