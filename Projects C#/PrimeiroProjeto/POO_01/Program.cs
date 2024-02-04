using System;
using System.Globalization;
/* Calcular area de dois triangulos sem POO */
namespace POO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; //usando a Classe Triangulo referente aos atributos do triangulo
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Entre com medidas do triangulo X: ");
            x.A = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com medidas do triangulo y: ");
             y.A = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalculaArea(); //Chamando o metodo criado na Classe triangulo
            double areaY = y.CalculaArea();

            Console.Write($"Area X = {areaX:F4} \n");
            Console.Write($"Area Y = {areaY:F4} \n");
            bool maior = (areaX > areaY);
                if (maior == true)
                {
                    Console.Write("Maior Area é X");
                }
                else
                {
                    Console.Write("Maior é Y");
                }

        }
    }
}