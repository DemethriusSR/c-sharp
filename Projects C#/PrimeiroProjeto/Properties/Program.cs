using System;
/* Teste 02 */
namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto( "TV 4K", 500.00, 10);

            Console.Write(produto);
            
        }
    }
}