using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Produto
    {
        private static string _nome;
        private static double _preco;
        private static int _qtd;


        public Produto()
        {

        }
        public Produto(string nome, double preco, int qte) // Construtor da Classe Produto
        {
            _nome = nome;
            _preco = preco;
            _qtd = qte;
        }
        public string Nome { // Properties para visualização da variável nome

            get { return _nome; }

            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco { // Properties para visualização da variável preço
            get { return _preco; }
        }

        public int Qtd { // Properties para visualização da variável qtd
            get { return _qtd; } 
        }

        public override string ToString()
        {
            return $"{Nome} R$ {Preco} QTD = {Qtd}.";
        }
    }
}
