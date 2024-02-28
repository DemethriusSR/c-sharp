using System;
/* Calcula diferença entre produtos de 4 numeros */
namespace Lista01Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu primeiro numero:... ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite seu segundo numero:... ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite seu segundo numero:... ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite seu segundo numero:... ");
            int num4 = int.Parse(Console.ReadLine());

            int diferenca = (num1*num2 - num3*num4);

            Console.WriteLine("#######################################");
            Console.WriteLine($"#  Diferenca de produtos = {diferenca}        #");
            Console.WriteLine("#######################################");
            Console.ReadKey();
        }

    }
}

