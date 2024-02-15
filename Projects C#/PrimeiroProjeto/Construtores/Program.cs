using System;
using System.Globalization;
/* Utilizando construtores */
namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.Write("Dados dos Produtos (Nome/Preço/QTD)"); //Mostrando Dados do Produto
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //int qtd = int.Parse(Console.ReadLine());

                Produto p = new Produto(nome, preco);

                Console.Write($"\n Produto {p}");

                Console.WriteLine();
                Console.Write("Quantos itens deseja adicionar ?");// Adicionando Produtos
                int qte = int.Parse(Console.ReadLine());
                Produto.AdicionarProdutos(qte); //Chamando o método

                Console.Write($"\n Produto {p}");

                Console.WriteLine();
                Console.Write("Quantos itens deseja remover ?");// Removendo produtos
                qte = int.Parse(Console.ReadLine());
                Produto.RemoveProdutos(qte);

                Console.WriteLine($"\n Produto {p}");

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }


        }
    }
}