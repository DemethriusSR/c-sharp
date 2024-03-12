using System;
/* Conhecendo Params */
namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Somar.Soma(new int[] { 2, 3 });
            int num2 = Somar.Soma(new int[] { 2, 5, 3 });

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}