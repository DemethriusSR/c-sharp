using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seus numeros:... ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                                              
                 while (n1 >= 0.0){
                     double raiz = Math.Sqrt(n1);
                     Console.WriteLine(raiz.ToString("F3",CultureInfo.InvariantCulture));
                     Console.WriteLine("Digite seus numeros:... ");
                     n1 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                 }
            Console.WriteLine("Número negativo inválido !");
              
        }
    }
}

