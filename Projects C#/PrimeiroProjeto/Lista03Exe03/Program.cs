using System;
/* Ler tipo de combustivel e mostrar qual combustivel escolhido */
namespace Lista03Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int g = 0;
            int d = 0;

            Console.WriteLine(">>>>>> Escolha um combustivel: <<<<<<<");
            Console.WriteLine("1. Alcool ");
            Console.WriteLine("2. Gasolina ");
            Console.WriteLine("3. Disel ");
            Console.WriteLine("4. Sair ");
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());

            while (escolha != 4)
            {
                    if (escolha == 1) {
                        a += 1;
                    }
                    else if (escolha == 2){
                        g += 1;
                    }
                    else if (escolha == 3)
                    {
                        d += 1;
                    }
                    else if (escolha == 4)
                    {
                        Console.WriteLine("Muito obrigado !");
                    }
                    else
                    {
                        Console.Write("Escolha outra Opção ");
                    }                
                   
                    Console.WriteLine(">>>>>> Escolha um combustivel: <<<<<<<");
                    
                    Console.WriteLine("1. Alcool ");
                    Console.WriteLine("2. Gasolina ");
                    Console.WriteLine("3. Disel ");
                    Console.WriteLine("4. Sair ");
                    Console.WriteLine("");
                    escolha = int.Parse(Console.ReadLine());
            }
            
            Console.Write($"Total de abastecimento ALCOOL = {a} GASOLINA = {g} DISEL = {d} \n");
        }
    }
}