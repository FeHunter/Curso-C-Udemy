using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main (string[] ags){

            Usuario Use = new Usuario ();

            NumeroDaConta (Use);
            NomeDoTitular (Use);
            DepositoInicial (Use);
            DadosDaConta (Use);
            FazerDeposito (Use);
            FazerSaque (Use);

        }

        static void NumeroDaConta (Usuario use){
            int Conta = 0; bool Completo = false;

            while (!Completo){
                // Entra com dados
                System.Console.WriteLine();
                Console.Write("Entre o número da conta: ");
                Conta = int.Parse(Console.ReadLine());

                // Finaliza se o n° for valido
                if (Conta.ToString().Length == 4){
                    use.SetConta (Conta);
                    Completo = true;
                }
                // Repete o codigo
                else {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Numero Invalído, digite novamente.");
                }
            }
        }

        static void NomeDoTitular (Usuario use){
           //Usuario Use = new Usuario ();
            bool Completo = false;
            string Nome = "";

            while (!Completo){
                System.Console.WriteLine();
                System.Console.WriteLine("Entre o titular da conta: ");
                Nome = Console.ReadLine().ToUpper();

                if (Nome != null && Nome.Length > 4){
                    use.SetNomeDoTitular(Nome);
                    Completo = true;
                }else {
                    System.Console.WriteLine("Nome inválido, digite novamente.");
                }
            }
        }

        static void DepositoInicial (Usuario use){
            //Usuario Use = new Usuario ();
            string VerficarDepositoInicial = "";

            while (VerficarDepositoInicial == ""){

                System.Console.WriteLine("Havéra depósito inicial (s/n)?");
                VerficarDepositoInicial = Console.ReadLine().ToLower();

                if (VerficarDepositoInicial == "s"){
                    System.Console.WriteLine();
                    System.Console.Write("Entre o valor do depósito inicial: ");
                    double Deposito = double.Parse(Console.ReadLine());
                    use.Deposito(Deposito);
                }
            }
        }

        static void DadosDaConta (Usuario use){
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine("Conta: "
            +use.GetConta()
            +", Titular: "+use.GetNomeDoTitular()
            +", Saldo: $"+use.GetSaldo().ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    
        static void FazerDeposito (Usuario use){
            System.Console.WriteLine();
            System.Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            use.Deposito(valor);
            DadosDaConta (use);
        }
    
        static void FazerSaque (Usuario use){
            System.Console.WriteLine();
            System.Console.Write("Entre um valor para saque: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            use.Saque(valor);
            DadosDaConta(use);
        }
    }
}