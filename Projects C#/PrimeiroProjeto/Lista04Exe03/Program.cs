using System;
using System.Globalization;
using System.Linq.Expressions;
/* Ler numero de casos cada caso contem 3 valores e calcular media ponderada */
namespace Lista04Exe03
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Numero de casos: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("DIgite as Notas: ");

                for (int i = 0; i < n; i++)
                {

                    string[] line = Console.ReadLine().Split(' ');
                    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }
        }
    }