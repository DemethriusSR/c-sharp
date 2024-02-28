using System;
using System.Globalization;
using System.Linq.Expressions;
/* Ler numero de casos depois leia pares de numeros e tente dividi-los */
namespace Lista04Exe03
{
    class Program
    {
        static void Main(string[] args)
        {

            try // usando try catch para melhor visualização dos erros.
            {
                Console.Write("Numero de casos: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("DIgite pares de numeros: ");

                for (int i = 0; i < n; i++)
                {

                    string[] line = Console.ReadLine().Split(' ');
                    int a = int.Parse(line[0]);
                    int b = int.Parse(line[1]);

                    if (b == 0)
                    {
                        Console.WriteLine("DIVISAO IMPOSSIVEL !");
                    }
                    else
                    {
                        double div = (double)a / b;

                        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}