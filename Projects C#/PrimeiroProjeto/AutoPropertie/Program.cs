using System;
using System.Globalization;
/* Encapsulamento */
namespace AutoPropertie
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Produto p = new Produto("TV", 500.00, 10);

                Console.WriteLine(p.GetNome());
                p.SetNome("TV 4K SAMSUNG");

                Console.WriteLine(p.ToString());

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }


        }
    }
}