using System;
/* Teste */
namespace ExePooFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome1, idade1, nome2,idade2;
            nome1 = new Pessoa();
            idade1 = new Pessoa();
            nome2 = new Pessoa();
            idade2 = new Pessoa();

            Console.Write("Digite nome e idade ");
            nome1.nome = Console.ReadLine();
            idade1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite nome e idade ");
            nome2.nome = Console.ReadLine();
            idade2.idade = int.Parse(Console.ReadLine());

            if (idade1.idade > idade2.idade)
            {
                Console.WriteLine($"Mais velho é {nome1.nome}");
            }
            else
            {
                Console.WriteLine($"Mais velho é {nome2.nome}");
            }


        }
    }
}