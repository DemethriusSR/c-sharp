using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{

    public class Calculadora
    {
        private static double Pi = 3.14;
        public static double Raio;
       public static double Circunferencia()
        {
            return 2.0 * Pi * Raio;
        }

        public static double Volume()
        {
            return 4.0 / 3.0 * Pi * Raio * Raio * Raio;
        }

        public override string ToString()
        {
            return $" Circunferencia = {Circunferencia():F2}"
                 + $"\n Volume = {Volume():F2}"
                 + $"\n PI = {Pi:F2} \n";
        }
    }
}
