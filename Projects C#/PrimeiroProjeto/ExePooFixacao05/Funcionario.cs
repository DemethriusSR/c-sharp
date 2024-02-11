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
        public double Result;

        public double SalarioLiquido()
        {
            return Result =  SalBruto - Imposto;
        }

        public double AumentoSalario()
        {
            return SalarioLiquido() + ( SalBruto * (Porcento/100) );
        }
            
        public override string ToString()
        {
            return   $"\n Nome: {Nome} "
                    +$"\n Salario Bruto R$ {SalBruto} "
                    +$"\n Imposto de R$ {Imposto}"
                    +$"\n Nome: {Nome} "
                    +$"\n Salario Liquido R$ {AumentoSalario():F2} ";
        }
    }
}
