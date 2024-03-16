using System;
using System.Globalization;
/* Usando LISTAS */
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> lista = new List<string>();

            lista.Add("Ana");
            lista.Add("Demethrius");
            lista.Add("Pedro");
            lista.Add("Dimitri");
            lista.Add("Joacir");
            lista.Add("Demethria");
            lista.Insert(0, "Narcia");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("List count " + lista.Count);

             Console.WriteLine("----------------------");

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeiro {s1}");
             Console.WriteLine("----------------------");

            string s2 = lista.FindLast(x => x[0] == 'D');
            Console.WriteLine($"Ultimo {s2}");
             Console.WriteLine("----------------------");

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Posicao {pos1}");
             Console.WriteLine("----------------------");

            int pos2 = lista.FindLastIndex(x => x[0] == 'D');
            Console.WriteLine($"Posicao {pos2}");
             Console.WriteLine("----------------------");

            List<string> lista2 = lista.FindAll(x => x.Length == 5);

             Console.WriteLine("----------------------");

            foreach(var item2 in lista2)
            {
                Console.WriteLine(item2);
            }

            lista.Remove("Narcia");
            lista.RemoveRange(2,1);

            Console.WriteLine("----------------------");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAll(x => x[0] == 'D');

            Console.WriteLine("----------------------");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }



        }
    }
}