using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vai digitar qauntos numeros :... ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma dos seus número = {Calcula(num)}");

            int Calcula (int num) {
                    int x = 0;                

                        for (int i = 1;  i <= num; i++)
                        {
                        
                            x += i;            
                        }
                    return (x);
                 }
            
        }
    }
}

