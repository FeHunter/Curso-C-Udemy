using System;
using System.Collections.Generic;
using System.Globalization;

namespace GerenciadorDeEstoque {
    class Program {
        static void Main (string[] args){
            Produto p = new Produto ();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine ("Dados do produto: " + p.ToString());
            Console.WriteLine(); // pular linha

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionadoProduto(qte);

            Console.WriteLine(); // pular linha
            Console.WriteLine ("Dados atualizados: " + p);

            Console.WriteLine(); // pular linha
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qteR = int.Parse(Console.ReadLine());
            p.RemoverProduto(qteR);
            
            Console.WriteLine(); // pular linha
            Console.WriteLine ("Dados atualizados: " + p);

        }
    }
}
