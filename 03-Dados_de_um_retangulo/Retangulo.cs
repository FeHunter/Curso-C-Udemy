using System;

namespace DadosRetangulo {
    class Retangulo {
        public double largura, altura;

        public double Area (){
            return largura * altura;
        }
        public double Perimetro (){
            return 2*(altura + largura);
        }
        public double Diagonal (){
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}