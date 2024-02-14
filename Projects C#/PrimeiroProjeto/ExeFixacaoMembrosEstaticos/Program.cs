using System;
/* Conversor de Moeda */
namespace ExeFixacaoMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularConversao calc = new CalcularConversao();

            Console.Write("Qual a cotação $ ");
            CalcularConversao.Cotac = double.Parse(Console.ReadLine());
            Console.Write("Quantos Dollares vai comprar ? ");
            CalcularConversao.QtdDollar = double.Parse(Console.ReadLine());

            Console.Write(calc);
        }
    }
}