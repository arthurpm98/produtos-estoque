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
        private string _nome;
        private double _preco;
        private int _quantidadeEstoque;
        private double _valorTotalEstoque;

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void setPreco(double preco)
        {
            _preco = preco;
        }

        public int GetQuantidadeEstoque()
        {
            return _quantidadeEstoque;
        }

        public double GetValorTotalEstoque()
        {
            return _valorTotalEstoque;
        }

        public double ValorTotalEmEstoque() 
        {
            _valorTotalEstoque = _preco * _quantidadeEstoque;
            return _valorTotalEstoque;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidadeEstoque += quantidade;
            ValorTotalEmEstoque();
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidadeEstoque -= quantidade;
            ValorTotalEmEstoque();
        }

        public override string ToString()
        {
            return "Descrição: " + _nome 
                + " - Preço: $" + _preco.ToString("F2", CultureInfo.InvariantCulture) 
                + " - Quantidade em estoque: " + _quantidadeEstoque.ToString("F2", CultureInfo.InvariantCulture)
                + " - Valor Total em estoque: $" + _valorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
