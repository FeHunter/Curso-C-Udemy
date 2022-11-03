using System;
using System.Globalization;

namespace ContaBancaria {
    class Usuario {
        
        public int Numero { get; private set; }
        public string Titular {get; set;}
        public double Saldo {get; private set;}
        private double Taxa = 5.0;
        
        public Usuario (int numero, string titular){
            Numero = numero; Titular = titular;
        }
        public Usuario (int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito (double quantia){
            Saldo += quantia;
        }
        public void Saque (double quantia){
            Saldo -= (quantia+Taxa);
        }

        public override string ToString(){
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}