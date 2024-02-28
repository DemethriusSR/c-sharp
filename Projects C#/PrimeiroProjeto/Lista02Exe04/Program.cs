using System;
/* Ler dois valores de horas e calcular DIF entre elas */
namespace Lista02Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite Hora inicial e hora final ");
            string[] valores = Console.ReadLine().Split(' ');

            int hora_inicial = int.Parse(valores[0]);
            int hora_final = int.Parse(valores[1]);

            int duracao;

            if (hora_inicial <  hora_final)
            {
                duracao = hora_final - hora_inicial;
            }
            else
            {
                duracao = 24 - hora_inicial + hora_final;
            }
            Console.Write($"\n Jogo durou {duracao} Horas ! \n");
        }
    }
}