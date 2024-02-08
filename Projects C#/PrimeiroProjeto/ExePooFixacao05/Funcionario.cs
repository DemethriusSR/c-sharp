using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExePooFixacao05
{
    public class Funcionario
    {
        public string Nome;
        public double SalBruto;
        public double Imposto;
        public double Porcento;

        public double SalarioLiquido()
        {
            return SalBruto -= Imposto;
        }

        public double AumentoSalario()
        {
            return SalarioLiquido() + (SalBruto * Porcento);
        }
            
        public override string ToString()
        {
            return $"\n Nome: {Nome} "
                +$" Salario Bruto R$ {SalBruto} "
                +$"\n Imposto de {Imposto} %"
                + $"\n Nome: {Nome} "
                + $"\n Salario Liquido R$ {SalarioLiquido():F2} ";
        }
    }
}
