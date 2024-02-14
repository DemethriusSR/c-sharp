using System;
using System.Globalization;
/* Calculando Circunferencia e Volume */
namespace MembrosEstaticos
{
    class Program
    {
       static void Main(string[] args)
        {
            try { 
                Calculadora calc = new  Calculadora();

                Console.Write("Entre com RAIO: ");
                Calculadora.Raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write(calc);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}