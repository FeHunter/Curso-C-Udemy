using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main (string[] ags){

            Usuario use;

            System.Console.WriteLine();
            System.Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            System.Console.Write("Haverá depósito inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S'){
                System.Console.Write("Entre o valor inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                use = new Usuario (numero, titular, depositoInicial);
            }else {
                use = new Usuario (numero, titular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta");
            System.Console.WriteLine(use);

            System.Console.WriteLine();
            System.Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            use.Deposito (quantia);
            System.Console.WriteLine("Dados da conta atualizado: ");
            System.Console.WriteLine(use);

            System.Console.WriteLine();
            System.Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            use.Saque (quantia);
            System.Console.WriteLine("Dados da conta atualizado: ");
            System.Console.WriteLine(use);
        }
    }
}