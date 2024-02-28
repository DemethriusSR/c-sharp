using System;
using System.Globalization;
using System.Runtime.InteropServices;
/* ExeFixacaoContrutoresPropertiesAutoproperties */
namespace ExeFixacaoContrutoresPropertiesAutoproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco dados;

            Console.Write("Nome e número da conta ? \n");
            string nome = Console.ReadLine();
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Haverá deposito incial ? (S | N) ");
            char resp = char.Parse(Console.ReadLine());
            char.ToLower(resp);
                if (resp == 's')
                {
                    Console.Write("Valor R$ ");
                    double depositoinicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    dados = new ContaBanco(numConta, nome, depositoinicial);
                }
                else
                {
                    dados = new ContaBanco(numConta, nome);
                }

            Console.WriteLine();
            Console.Write(dados);

            Console.WriteLine();
            Console.WriteLine("Valor deposito R$ ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Deposito(quantia);
            Console.WriteLine(">>> Deposito realizado ! <<<");
            Console.WriteLine(dados);

            Console.WriteLine();
            Console.WriteLine("Valor saque R$ ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Saque(quantia);
            Console.WriteLine(">>> Saque realizado ! Add Taxa de R$ 5.00 <<< ");
            Console.WriteLine(dados);
        }
    }
}