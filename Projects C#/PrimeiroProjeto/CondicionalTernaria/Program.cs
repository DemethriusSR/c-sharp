using System;
using System.Globalization;
/* Condicional Ternária */
namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Valor: ");
            double num = int.Parse(Console.ReadLine());

            double desconto = (num < 20.0) ? num * 0.1 : num * 0.05; // Condicao Ternaria

            Console.WriteLine($"Desconto = R$ {desconto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}