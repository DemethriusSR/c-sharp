using System;
using System.Globalization;
/* Digitar numero de linhas e calcular quadrado e cubo dos numeros digitados */
namespace BaseClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            try // usando try catch para melhor visualização dos erros.
            {
                Console.Write("Numero de casos: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite numeros: ");

                for (int i = 1; i <= n; i++)
                {

                    /*string[] line = Console.ReadLine().Split(' ');
                    int a = int.Parse(line[0]);
                    int b = int.Parse(line[1]);

                    double quadrado = Math.Pow(a,2);
                    double cubo = Math.Pow(b,3);*/



                    Console.WriteLine($"{i} -  {Math.Pow(i,2)}, {Math.Pow(i,3)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
