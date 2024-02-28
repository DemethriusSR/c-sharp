using System;
/* Nome do aluno e 3 notas e mostrar se o aluno esta aprovado com base na nota final */
namespace ExePooFixacao06
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Aluno aluno = new Aluno();

                Console.Write("Nome : ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine(" 3 Notas: ");
                aluno.Notas = double.Parse(Console.ReadLine());

                for (int i = 0; i < 2; i++)
                {
                    aluno.Adiciona();
                    aluno.Notas = double.Parse(Console.ReadLine());
                }

                Console.WriteLine(aluno);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}