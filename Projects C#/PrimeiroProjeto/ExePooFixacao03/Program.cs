using System;
using System.Globalization;
/* Criar uma classe produtos com atributos e metodos e fazer insert e remove na classe */
namespace ExePooFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Produto p = new Produto();

                Console.WriteLine("Dados dos Produtos (Nome/Preço/QTD)");
                p.nome = Console.ReadLine();
                p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.qtd = int.Parse(Console.ReadLine());

                Console.WriteLine($"Produto {p}");

            }
            catch (Exception e){
                Console.Write(e.ToString());
            }


        }
    }
}