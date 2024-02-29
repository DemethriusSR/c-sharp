using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFixacaoContrutoresPropertiesAutoproperties
{
    class ContaBanco
    {
        public int NumConta { get; private set; }

        public double Saldo { get; private set; }

        public string Nome { get; set; }


        public ContaBanco(int numConta, string nome) {
            NumConta = numConta;
            Nome = nome;
        }

       
        
        public  ContaBanco ( int numConta, string nome, double saldo): this(numConta,nome)
        {
            Deposito(saldo);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }


        public override string ToString()
        {
            return $"Conta: {NumConta} | Nome: {Nome} | Saldo R$ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}\n\n";
        }

    }
}
