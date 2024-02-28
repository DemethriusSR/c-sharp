using System;
/* Lê valores de horas e salario e calcula salario total */
namespace Lista01Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numerode Func:... ");
            int func = int.Parse(Console.ReadLine());
            Console.Write("Horas trabalhadas:... ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Valor por Horas trabalhadas:... ");
            double valor = double.Parse(Console.ReadLine());
           
            double salario = horas * valor;

            Console.WriteLine("#######################################");
            Console.WriteLine($"#        FUNC = {func}                   #");
            Console.WriteLine($"#        SALARIO = R$ {salario.ToString("F2")}        #");
            Console.WriteLine("#######################################");
            Console.ReadKey();
        }

    }
}

