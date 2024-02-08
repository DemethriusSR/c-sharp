using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExePooFixacao04
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double AreaRetangulo()
        {
            return Altura * Largura;
        }

        public double PerimetroRetangulo()
        {
            return 2 * (Altura + Largura);
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura,2));
        }

        public override string ToString()
        {
            return $"Medidas {Altura} e {Largura} "
                +$" \n Área = {AreaRetangulo()}"
                +$" \n Perimetro = {PerimetroRetangulo()}"
                +$" \n Diagonal = {DiagonalRetangulo()}";
        }
    }
}
