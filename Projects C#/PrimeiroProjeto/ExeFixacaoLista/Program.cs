using ExeFixacaoLista;
using System;
using System.Globalization;
/* Exercício de Listas */
namespace BaseClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Vai registrar quantos Funcionários ?");
                int num = int.Parse(Console.ReadLine());

                List<Funcionario> funcionario = new List<Funcionario>();

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"ID # {i}");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nome # ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Salario R$ ");
                    double salario = double.Parse(Console.ReadLine());
                    funcionario.Add(new Funcionario(id, nome, salario));
                }

                foreach (var item in funcionario)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("----------------------------");
                Console.WriteLine("Qual ID vai ser corrigido o Salario ?");
                int aux = int.Parse(Console.ReadLine());



                Funcionario funcionarioFind = funcionario.Find(x => x.Id == aux);

                if (funcionarioFind != null)
                {
                    Console.WriteLine(" Digite a porcentagem % ?");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionarioFind.SalaryAdd(valor);

                    Console.WriteLine("---- Update lista de Funcionarios -----");
                    foreach (var item in funcionario)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("ID Inválido ");
                }
                Console.WriteLine("----------------------------");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}