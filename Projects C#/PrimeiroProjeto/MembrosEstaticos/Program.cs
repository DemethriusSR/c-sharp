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
            double volume = Volume(raio);

            Console.WriteLine($" Circunferencia = {circ:F2}");
            Console.WriteLine($" Circunferencia = {volume:F2}");
            Console.WriteLine($" PI = {Pi:F2}");

        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0  * Pi * raio * raio * raio;
        }
    }
}