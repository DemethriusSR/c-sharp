using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExePooFixacao06
{
    public class Aluno
    {
        public double Final = 0,Notas;
        public string Nome, Status;


        public double Adiciona()
        {  
            return Final  +=  Notas;
        }

        public string StatusAluno()
        {
            if (Final >= 60)
            {
                return Status = "APROVADO";
            }
            else
            {
                return Status = $"REPROVADO  NF = {Final - 60}";
            }
        }

        public override string ToString()
        {
            return $"Nome {Nome}" 
                +$"\nNota Final = {Adiciona()}"
                +$" Situação {StatusAluno()}";
        }

    }
}
