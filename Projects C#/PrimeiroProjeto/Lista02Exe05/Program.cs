using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;
/* Ler codigo do item e valor do item e calcular valor final a pagar. */
namespace Lista02Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Codigo do Produto :  ");
            int codigo = int.Parse(Console.ReadLine());
            string [] nome = { "Cachorro quente", "X-Salada", "X-Bacon", "Torrada Simples", "Refrigerante" };
            double qtd = 0;
            

            double total = 0;

            switch (codigo)
            {
                case 0:
                    Console.Write($"Quantos {nome[0]} deseja ?  ");
                    qtd = double.Parse(Console.ReadLine());
                    total = qtd * 4;
                    Console.WriteLine($"\n Seu pedido foi {nome[0]} e Total = R$ {total.ToString("F2")}");
                    break;
                case 1:
                    Console.Write($"Quantos {nome[1]} deseja ?  ");
                    qtd = double.Parse(Console.ReadLine());
                    total = qtd * 4.5;
                    Console.WriteLine($"\n Seu pedido foi {nome[1]} e Total = R$ {total.ToString("F2")}");
                    break;
                case 2:
                    Console.Write($"Quantos {nome[2]} deseja ?  ");
                    qtd = double.Parse(Console.ReadLine());
                    total = qtd * 5;
                    Console.WriteLine($"\n Seu pedido foi {nome[2]} e Total = R$ {total.ToString("F2")}");
                    break;
                case 3:
                    Console.Write($"Quantos {nome[3]} deseja ?  ");
                    qtd = double.Parse(Console.ReadLine());
                    total = qtd * 2;
                    Console.WriteLine($"\n Seu pedido foi {nome[3]} e Total = R$ {total.ToString("F2")}");
                    break;
                case 4:
                    Console.Write($"Quantos {nome[4]} deseja ?  ");
                    qtd = double.Parse(Console.ReadLine());
                    total = qtd * 1.5;
                    Console.WriteLine($" \n Seu pedido foi {nome[4]} e Total = R$ {total.ToString("F2")}");
                    break;
                default:
                    Console.WriteLine("Opção Inválida !");
                break;
            }
        }
    }
}