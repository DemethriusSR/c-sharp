using System;
/* Mostra a SOMA de dois numeros */
namespace Lista01Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu primeiro numero:... ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite seu segundo numero:... ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;

            Console.WriteLine("##################################");
            Console.WriteLine($"#          Soma = {soma}             #");
            Console.WriteLine("##################################");
            Console.ReadKey();
        }

    }
}
