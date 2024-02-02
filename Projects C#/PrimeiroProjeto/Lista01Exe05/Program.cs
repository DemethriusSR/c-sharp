using System;
/* Usuario insere codigo de dois itens e calcula valor total a ser pago */
namespace Lista01Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Codigo da peça:... ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Codigo da peça 2:... ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.Write($"QTD da peça {codigo} :... ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write($"QTD da peça {codigo2}:... ");
            int qtd2 = int.Parse(Console.ReadLine());
            Console.Write($"Valor Unitário da peça {codigo}:... ");
            double unitValor = double.Parse(Console.ReadLine());
            Console.Write($"Valor Unitário da peça {codigo2}:... ");
            double unitValor2 = double.Parse(Console.ReadLine());

            double total = (qtd * unitValor) + (qtd2 * unitValor2);

            Console.WriteLine("#######################################");
            Console.WriteLine($"#  Valor a Pagar R$ = {total.ToString("F2")}        #");
            Console.WriteLine("#######################################");
            Console.ReadKey();
        }

    }
}

