using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExePooFixacao03
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int qtd;

        public double ValorTotal()
        {
           return preco * qtd;
        }

        public void AdicionarProdutos(int qte)
        {
            qtd += qte;
        }

        public void RemoveProdutos(int qte)
        {
            qtd -= qte;
        }

        public override string ToString() //Usando a function ToString () utilizado para formatar saidas já pré defenidas
        {
            return nome 
                   + ", R$ " 
                   + preco.ToString("F2",CultureInfo.InvariantCulture) 
                   + ", " +qtd 
                   +" unidades Total R$ "
                   +ValorTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
