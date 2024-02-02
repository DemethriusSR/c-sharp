using System;
using System.Globalization;
/* Teste */
namespace Lista02Exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salário R$ ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;
            double dif = 0;

            if ((salario < 0 ) && (salario <= 2000))
            {
                Console.WriteLine(" IMPOSTO ISENTO !");
            }
            else if ((salario >= 2000.01) && (salario <= 3000))
            {
                imposto += (salario * 0.08);
                Console.WriteLine($" IMPOSTO PAGO R$ {imposto:F2}");
            }
            else if ((salario >= 3000.01) && (salario <= 4500))
            {
                dif = salario - 2000;
                imposto += (dif * 0.08);
                imposto += ((salario - 3000) * 0.18);
                Console.WriteLine($" IMPOSTO PAGO R$ {imposto:F2}");
            }
            else if (salario > 4500)
            {
              
                imposto += ((salario - 2000) * 0.08);
                imposto += ((salario - 3000) * 0.18);
                imposto += ((salario - 4500) * 0.28);
                Console.WriteLine($" IMPOSTO PAGO R$ {imposto:F2}");
            }
            //LOGICA DO CALCULO PRECISA SER REVISADA
        }
    }
}