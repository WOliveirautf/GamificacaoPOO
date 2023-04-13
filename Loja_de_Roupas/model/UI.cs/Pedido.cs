using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Roupas.model.UI.cs
{
    internal class Pedido
    {
        private Cliente cliente;
        private List<Produto> produtos;
        private double total;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
            this.produtos = new List<Produto>();
            this.total = 0;
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            total += produto.Preco * produto.Quantidade;
        }
    }
}
