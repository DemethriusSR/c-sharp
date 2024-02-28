using System;
/* Difitar medidas e calcular area, perimetro e diagonal de retangulo */
namespace ExePooFixacao04
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Retangulo ret = new Retangulo();

                Console.Write("Altura: ");
                ret.Altura = int.Parse(Console.ReadLine());
                Console.Write("Largura: ");
                ret.Largura = int.Parse(Console.ReadLine());
              

                Console.Write($"\n {ret}");
            }catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
