using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExeFixacaoMembrosEstaticos
{
    public class CalcularConversao
    {
        public static double Cotac;
        public static double QtdDollar;
        public static double Iof = 6.0;

        public static double Conversor()
        {
            double total = Cotac * QtdDollar;
            return total + total * (Iof/100);
        }

        public override string ToString()
        {
            return $" Total em R$ {Conversor():F2}";
        }
    }
}
