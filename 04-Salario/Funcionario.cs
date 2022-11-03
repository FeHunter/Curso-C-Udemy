using System;
using System.Globalization; 

namespace Salario{
    class Funcionario{
        public string Nome = "";
        public double SalarioBruto, Imposto;

        public double SalarioLiquido (){
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario (double porcentagem){
            SalarioBruto += (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString() {
            return Nome+", $"+SalarioLiquido();
        }
    }
}