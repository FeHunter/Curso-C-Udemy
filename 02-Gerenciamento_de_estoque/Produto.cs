using System;
using System.Collections.Generic;
using System.Globalization;

namespace GerenciadorDeEstoque {
    class Produto {
        public string Nome = "nome";
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque (){
            return Preco * Quantidade;
        }

        public void AdicionadoProduto (int quantidade){
            Quantidade += quantidade;
        } 

        public void RemoverProduto (int quantidade){
            Quantidade -= quantidade;
        }

        public override string ToString(){
            return Nome.ToUpper()+" Preço: $"+Preco.ToString("F2", CultureInfo.InvariantCulture)+" Quantidade: "+Quantidade+" unidades Total : $"+ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
