using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Roupas.model.UI.cs
{
    internal class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
    }
}
