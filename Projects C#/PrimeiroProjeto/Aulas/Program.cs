using System;
using System.Globalization;

namespace Aulas 
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte n1 = 126;
            int n2 = 1000;
            int n3 = 419413074;
            long n4 = 16736413949149;
            double n5 = 11.1434141343;*/

            /*int idade = 32;
            string nome = "Demethrius";
            double saldo = 4979.689887677;*/

            /*Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5.ToString("F2")); //Controla casas decimais de double */

            /****************************** Tipos de saida de Dados ****************************************/

            /* Console.WriteLine("{0} tem {1} anos e possui saldo de R$ {2:F2}", nome, idade, saldo); //PlaceHolder
             Console.WriteLine($"{nome} tem {idade} anos e possui R$ {saldo.ToString("F2")}"); //Concatenação
             Console.WriteLine(nome +" tem "+idade+" anos e possui R$ "+saldo.ToString("F2")); //Interpolação*/

            /****************************** Tipos de Entrada de Dados ****************************************/

            /*string[] v = Console.ReadLine().Split(' '); // Digitar colocando espaço entre as palavras
            string a = v[0];
            string b = v[1];
            string c = v[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);*/

            /****************************** Tipos de Entrada de Dados ****************************************/

            /*    Console.WriteLine("Digite n1, caractere e double: ");
                int n1 = int.Parse(Console.ReadLine());
                char ch = char.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura de ponto*/


            /*Console.WriteLine("Digite seu nome, sexo 'M' ou 'F', sua idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);*/
            
            /*Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));*//*
            Console.WriteLine($"Seu nome é {nome} seu sexo é {sexo} vc tem {idade} anos e possui {altura:F2} de altura");*/

            Console.WriteLine("Digite seu nome completo:... ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];           
            Console.WriteLine("Quantos quartos tem sua casa:... ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do produto:... ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura:... ");
            string[] aux = Console.ReadLine().Split(' ');
            string segundo_nome = aux[0];
            int idade = int.Parse(aux[1]);
            double altura = double.Parse(aux[2],CultureInfo.InvariantCulture);

         
            Console.WriteLine($"Seu nome é {nome}" +
                $" seu quarto possui {num} " +
                $"vc tem {idade} anos, o preço é {preco} " +
                $"seu sgundo nome é {segundo_nome} possui {altura:F2} M de altura !");
        }

    }
}

