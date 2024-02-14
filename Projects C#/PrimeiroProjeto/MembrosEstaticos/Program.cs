using System;
using System.Globalization;
/* Teste 1 */
namespace MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.Write("Entre com RAIO: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);

            Console.Write($" Circunferencia = {circ:F2}");
        }

        static double Circunferencia (double raio)
        {
            return 2.0 * Pi * raio;
        }
    }
}