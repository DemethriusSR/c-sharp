using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ListaExe01
{
    public class Exe01
    {
        int Soma ()
        {
            Console.Write("Digite seu primeiro numero:... ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite seu segundo numero:... ");
            int num2 = int.Parse(Console.ReadLine());
                int soma = num1 + num2;
            Console.WriteLine(soma);
            return(soma);
        }
        
    }
}
