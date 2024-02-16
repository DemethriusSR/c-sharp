using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
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

        public static double ValorTotal()
        {
            return _preco * _qtd;
        }

        public static void AdicionarProdutos(int qte)
        {
            _qtd += qte;
        }

        public static void RemoveProdutos(int qte)
        {
            _qtd -= qte;
        }

        public override string ToString() //Usando a function ToString () utilizado para formatar saidas já pré defenidas
        {
            return _nome
                   + ", R$ "
                   + _preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", " + _qtd
                   + " unidades Total R$ "
                   + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
