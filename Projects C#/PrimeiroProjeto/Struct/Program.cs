using System;
/* Aprendendo sobre Struc */
namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            Console.Write("Primeiro número ");
            p.X = double.Parse(Console.ReadLine());

            Console.Write("Segundo número ");
            p.Y = double.Parse(Console.ReadLine());

            Console.WriteLine(p);
        }
    }
}