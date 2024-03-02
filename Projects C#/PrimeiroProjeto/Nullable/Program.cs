using System;
using System.Reflection.Metadata;
/* Nullable valores nulos para variáveis de valor */
namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                double? x = null;
                double? y = 10;

                double a = x ?? 5; // Se X == NULL receberá 5.
                double b = y ?? 5;

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine();

                Console.WriteLine(x.GetValueOrDefault());
                Console.WriteLine(y.GetValueOrDefault());
                Console.WriteLine();

                Console.WriteLine(x.HasValue);
                Console.WriteLine(y.HasValue);
                Console.WriteLine();
                    if (x.HasValue)
                        {
                            Console.WriteLine(x.Value);
                        }
                    else
                        {
                            Console.WriteLine("X is NULL");
                            Console.WriteLine(a);
                        }

                    if (y.HasValue)
                        {
                            Console.WriteLine($"{y.Value}");
                        }
                    else
                        {
                            Console.WriteLine("Y is NULL");
                            Console.WriteLine(b);
                        }
            }catch (Exception e) {
                Console.Write(e.Message);
            };
        }
    }
}