using System;
using System.Collections.Generic;
using System.Text;

namespace Locacao
{
    class Produtos
    {
        private List<Produto> produtos;

        public Produtos()
        {
            produtos = new List<Produto>();
        }

        public Boolean adicionarProduto(Produto produto)
        {
            if (pesquisarProduto(produto) == null)
            {
                produtos.Add(produto);
                return true;
            }
            return false;
        }

        public Boolean removerProduto(Produto produto)
        {
            if (pesquisarProduto(produto) != null)
            {
                produtos.Remove(pesquisarProduto(produto));
                return true;
            }
            return false;
        }

        public Produto pesquisarProduto(Produto produto)
        {
            foreach(Produto p in produtos)
            {
                if(p.Equals(produto))
                {
                    return p;
                }
            }
            return null;
        }
    }
}
