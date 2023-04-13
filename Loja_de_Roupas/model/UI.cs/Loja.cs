using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Roupas.model.UI.cs
{
    internal class Loja
    {
        private List<Produto> estoque;
        private List<Produto> produtosVendidos;
        private List<Pedido> pedidos;

        public List<Produto> Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public List<Produto> ProdutosVendidos
        {
            get { return produtosVendidos; }
            set { produtosVendidos = value; }
        }

        public List<Pedido> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }

        public Loja()
        {
            this.estoque = new List<Produto>();
            this.produtosVendidos = new List<Produto>();
            this.pedidos = new List<Pedido>();
        }

        public void AdicionarProduto(Produto produto)
        {
            estoque.Add(produto);
        }

        public void CriarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
            foreach (Produto produto in pedido.Produtos)
            {
                Produto produtoEstoque = estoque.Find(p => p.Nome == produto.Nome);
                produtoEstoque.Quantidade -= produto.Quantidade;
                produtosVendidos.Add(produto);
            }
        }
    }
}
