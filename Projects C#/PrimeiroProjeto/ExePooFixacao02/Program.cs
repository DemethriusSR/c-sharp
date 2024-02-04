using System;
using System.Globalization;
/* Teste */
namespace ExePooFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaSalario nome1 = new PessoaSalario();
            PessoaSalario salario1 = new PessoaSalario();
            PessoaSalario nome2 = new PessoaSalario();
            PessoaSalario salario2 = new PessoaSalario();
            
            Console.Write("Digite o nome e salario ");
            nome1.nome = Console.ReadLine();
            salario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome e salario ");
            nome2.nome = Console.ReadLine();
            salario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.Write($" Media Salarial R$ {MediaSalario(salario1.salario,salario2.salario):F2}");



           double MediaSalario(double y, double x)
            {
                double media = (x + y) / 2;
                return media;
            }

        }
    }
}