using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Roupas.model.UI.cs
{
    class Cliente
    {
        private string nome;
        private string email;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Cliente(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
