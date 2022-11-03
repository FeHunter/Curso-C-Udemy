using System;
using System.Globalization;

namespace NotasDoAluno {
    class Aluno {
        public string Nome = "";
        public double Nota1, Nota2, Nota3;

        public double CalcularNota (){
            return Nota1 + Nota2 + Nota3;
        }

        public string EstatosFinal (){
            if (CalcularNota() >= 60){
                return "APROVADO";
            }else {
                return "REPROVADO faltam " + (60 - CalcularNota()) + " Pontos";
            }
        }
    }
}