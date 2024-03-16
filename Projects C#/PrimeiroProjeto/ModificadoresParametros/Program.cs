using System;
/* Modificadores de parametros ref e out */
namespace ModificadoresParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;

            Calc.Calcular( a , out triple);
            Console.WriteLine($" {a} x 3 = {triple}");
        }
    }
}