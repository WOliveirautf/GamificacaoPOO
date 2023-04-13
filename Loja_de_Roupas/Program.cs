using Loja_de_Roupas.model.UI.cs;

namespace Loja_de_Roupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja loja = new Loja();

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("----- LOJA DE ROUPA MEDVESTE -----");
                Console.WriteLine("1. Adicionar produto ao estoque");
                Console.WriteLine("2. Criar pedido");
                Console.WriteLine("3. Ver estoque");
                Console.WriteLine("4. Ver produtos vendidos");
                Console.WriteLine("5. Sair");
                Console.Write("Digite a opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite o preço do produto: ");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite a quantidade do produto: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        Produto produto = new Produto(nome, preco, quantidade);
                        loja.AdicionarProduto(produto);

                        break;

                    case 2:
                        Console.Write("Digite o nome do cliente: ");
                        string nomeCliente = Console.ReadLine();
                        Console.Write("Digite o email do cliente: ");
                        string emailCliente = Console.ReadLine();
                        Cliente cliente = new Cliente(nomeCliente, emailCliente);

                        Pedido pedido = new Pedido(cliente);
                        bool finalizarPedido = false;
                        while (!finalizarPedido)
                        {
                            Console.WriteLine("Selecione o produto para adicionar ao pedido:");
                            for (int i = 0; i < loja.Estoque.Count; i++)
                            {
                                Console.WriteLine(i + ". " + loja.Estoque[i].Nome + " - " + loja.Estoque[i].Preco);
                            }
                            Console.Write("Digite a opção: ");
                            int opcaoProduto = Convert.ToInt32(Console.ReadLine());
                            Produto produtoSelecionado = loja.Estoque[opcaoProduto];
                            Console.Write("Digite a quantidade: ");
                            int quantidadeSelecionada = Convert.ToInt32(Console.ReadLine());

                            if (quantidadeSelecionada > produtoSelecionado.Quantidade)
                            {
                                Console.WriteLine("Desculpe, não há itens suficientes em estoque.");
                            }
                            else
                            {
                                Produto produtoPedido = new Produto(produtoSelecionado.Nome, produtoSelecionado.Preco, quantidadeSelecionada);
                                pedido.AdicionarProduto(produtoPedido);

                                Console.Write("Finalizar pedido? (s/n): ");
                                string opcaoFinalizar = Console.ReadLine();
                                if (opcaoFinalizar == "s")
                                {
                                    finalizarPedido = true;
                                    loja.CriarPedido(pedido);
                                    Console.WriteLine("Total do pedido: " + pedido.Total);
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Estoque:");
                        foreach (Produto produtoEstoque in loja.Estoque)
                        {
                            Console.WriteLine(produtoEstoque.Nome + " - " + produtoEstoque.Preco + " - " + produtoEstoque.Quantidade);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Produtos vendidos:");
                        foreach (Produto produtoVendido in loja.ProdutosVendidos)
                        {
                            Console.WriteLine(produtoVendido.Nome + " - " + produtoVendido.Preco + " - " + produtoVendido.Quantidade);
                        }
                        break;
                    case 5:
                        sair = true;
                        break;
                }
            }
        }
    }
}
    