using System;
using System.Globalization;
/* Calcula area do circulo */
namespace Lista01Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o RAIO:... ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159; // Valor de PI para calculo da área do circulo

            double area = pi * (Math.Pow(raio,2));
            
            Console.WriteLine("##################################");
            Console.WriteLine($"#    Área = {area.ToString("F4")}         #");
            Console.WriteLine("##################################");
            Console.ReadKey();
        }

    }
}
