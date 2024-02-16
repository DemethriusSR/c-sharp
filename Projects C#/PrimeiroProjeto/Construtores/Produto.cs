using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        public static string Nome;
        public static double Preco;
        public static int Qtd;


        public Produto()
        {
            Qtd = 5;
        }

      /*  public Produto (string nome, double preco, int qtd) // Construtor da Classe Produto
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }*/

        public Produto (string nome, double preco) : this() // Construtor de 2 elementos com QTD fixo da Classe Produto
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto (string nome, double preco, int qtd) : this(nome,preco) // Construtor de 1 elemento aproveitando o construtor de 2 elementos
        {
            Qtd = qtd;
        }

        public static double ValorTotal()
        {
            return Preco * Qtd;
        }

        public static void AdicionarProdutos(int qte)
        {
            Qtd += qte;
        }

        public static void RemoveProdutos(int qte)
        {
            Qtd -= qte;
        }

        public override string ToString() //Usando a function ToString () utilizado para formatar saidas já pré defenidas
        {
            return Nome
                   + ", R$ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", " + Qtd
                   + " unidades Total R$ "
                   + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
