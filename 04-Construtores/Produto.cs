using System;
using System.Globalization;

namespace Construtores {
    class Produto {

        // Variáveis
        private string _nome = "";
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // Construtores
        public Produto (){}
        public Produto (string nome, double preco, int quantidade){
            _nome = nome; preco = Preco; quantidade = Quantidade;
        }
        public Produto (string nome, double preco){
            _nome = nome; preco = Preco; Quantidade = 0;
        }

        // Metódos GET & SET
        public string GetNome (){
            return _nome;
        }
        public void SetNome (string nome){
            if (nome != null && nome.Length > 1){
                _nome = nome;
            }
        }
        public void SetPreco (double preco){
            Preco = preco;
        }
        public void SetQuantidade (int quantidade){
            Quantidade = quantidade;
        }

        // Metódos
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}