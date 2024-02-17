using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertie
{
    public class Produto
        {
            private static string _nome;
            public double Preco { get; private set; }
            public int Qtd { get; private set; }


            public Produto()
            {

            }
            public Produto(string nome, double preco, int qte) // Construtor da Classe Produto
            {
                _nome = nome;
                Preco = preco;
                Qtd   = qte;
            }

            public string GetNome()
            {
                return _nome;
            }
            public void SetNome(string nome)
            {
                if (nome != null && nome.Length > 1)
                {
                    _nome = nome;
                }
            }

            public double ValorTotal()
            {
                return Preco * Qtd;
            }

            public void AdicionarProdutos(int qte)
            {
                Qtd += qte;
            }

            public void RemoveProdutos(int qte)
            {
                Qtd -= qte;
            }

            public override string ToString() //Usando a function ToString () utilizado para formatar saidas já pré defenidas
            {
                return _nome
                       + ", R$ "
                       + Preco.ToString("F2", CultureInfo.InvariantCulture)
                       + ", " + Qtd
                       + " unidades Total R$ "
                       + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
