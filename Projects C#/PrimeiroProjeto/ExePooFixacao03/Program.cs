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

                Console.WriteLine("Dados dos Produtos (Nome/Preço/QTD)"); //Mostrando Dados do Produto
                p.nome = Console.ReadLine();
                p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.qtd = int.Parse(Console.ReadLine());

                Console.WriteLine($"Produto {p}");

                Console.WriteLine();
                Console.Write("Quantos itens deseja adicionar ?");// Adicionando Produtos
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte); //Chamando o método

                Console.WriteLine($"\n Produto {p}");

                Console.WriteLine();
                Console.Write("Quantos itens deseja remover ?");// Removendo produtos
                qte = int.Parse(Console.ReadLine());
                p.RemoveProdutos(qte);

                Console.WriteLine($"\n Produto {p}");

            }
            catch (Exception e){
                Console.Write(e.Message);
            }


        }
    }
}