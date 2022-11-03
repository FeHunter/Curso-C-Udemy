using System;
using System.Globalization;

namespace ContaBancaria {
    class Usuario {
        
        private int _conta;
        private string _nomeTitular = "";
        private double Saldo;
        private double Taxa = 5.00;

        public void SetConta (int conta) { _conta = conta; }
        public int GetConta (){ return _conta; }
        public void SetNomeDoTitular (string nome){ _nomeTitular = nome; }
        public string GetNomeDoTitular (){ return _nomeTitular; }
        public double GetSaldo (){ return Saldo; }

        public void Deposito (double valor){
            Saldo += valor;
        }
        public void Saque (double valor){
            Saldo -= (valor+Taxa);
        }

    }
}