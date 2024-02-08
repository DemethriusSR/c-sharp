using System;
using System.Globalization;
/* Ler dados de funcionario, mostrar dados, aumentar salario com base em porcentage dada */
namespace ExePooFixacao05
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Nome Funcionario, Salario Bruto R$ e Imposto: ");
            funcionario.Nome = Console.ReadLine();
            funcionario.SalBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);

            Console.WriteLine("Para aumentar diga qual a Porcentagem ( ex: 10.0)");
            funcionario.Porcento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);



        }
    }
}