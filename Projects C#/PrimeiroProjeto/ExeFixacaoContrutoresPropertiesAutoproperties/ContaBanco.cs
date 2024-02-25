using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFixacaoContrutoresPropertiesAutoproperties
{
    class ContaBanco
    {
        public int NumConta { get; set; }

        private double _saldo;

        private static string _nome;


        public ContaBanco() { }

        public void SetSaldo(double saldo){
            _saldo = 0;
        }
        
        public  ContaBanco ( int numConta, string nome): this()
        {
            NumConta = numConta;
            _nome = nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public override string ToString()
        {
            return $"Conta: {NumConta} | Nome: {_nome} | Saldo R$ {_saldo}\n\n";
        }

    }
}
