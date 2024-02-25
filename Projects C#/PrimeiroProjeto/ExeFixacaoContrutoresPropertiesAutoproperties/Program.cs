using System;
/* ExeFixacaoContrutoresPropertiesAutoproperties */
namespace ExeFixacaoContrutoresPropertiesAutoproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco dados = new ContaBanco();

            Console.Write("Nome e número da conta ?");
            dados.SetNome(Console.ReadLine());
            int numConta = int.Parse(Console.ReadLine());
            dados.NumConta = numConta;           

            
            Console.Write(dados);
        }
    }
}