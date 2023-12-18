using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProdutosEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;
        public double ValorTotalEstoque;
        public double ValorTotalEmEstoque() 
        {
            ValorTotalEstoque = Preco * QuantidadeEstoque;
            return ValorTotalEstoque;
        }

        public void AdicionarProduto(int quantidade)
        {
            QuantidadeEstoque += quantidade;
            ValorTotalEmEstoque();
        }

        public void RemoverProduto(int quantidade)
        {
            QuantidadeEstoque -= quantidade;
            ValorTotalEmEstoque();
        }

        public override string ToString()
        {
            return "Descrição: " + Nome 
                + " - Preço: $" + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + " - Quantidade em estoque: " + QuantidadeEstoque.ToString("F2", CultureInfo.InvariantCulture)
                + " - Valor Total em estoque: $" + ValorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
