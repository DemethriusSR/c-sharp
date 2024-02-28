using System;
using System.Globalization;

namespace ExeFixacao001
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Gabinete";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("-------------- PRODUTOS -------------");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine("-------------- REGISTRO -----------------------");
            Console.WriteLine($"{idade} anos de idade, com código {codigo} e genero {genero} !");
            Console.WriteLine();
            Console.WriteLine("-------------- MEDIDA -------------");
            Console.WriteLine($"{medida.ToString("F3", CultureInfo.InvariantCulture)}");





        }
    }
}
