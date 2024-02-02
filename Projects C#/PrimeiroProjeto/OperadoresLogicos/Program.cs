using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 4 != 5 && 6 <= 3;
            bool c2 = 10 != 5 || 6 <= 3;
            bool c3 = !(4 == 5) && 6 >= 3; /* ! Exclamação símbolo de negação */

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}
