using System;
/* Usando laço ForEach */
namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = new string[] { "Debora", "Demethrius", "Debora" };

            for (int i  = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine("----------- ForEach ------------");

            foreach (string obj in words)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------------");
        }
    }
}