using System;

namespace Salario {
    class Program {
        static void Main (string[] args){

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            double media = 0;

            // Dados Funcionario 1 - Nome
            Console.WriteLine ("\n\n>> Nome do funcionário 1 :");
            funcionario1.nome = Console.ReadLine().ToLower();

            // Dados Funcionario 1 - Salario
            Console.WriteLine (">> Salário do funcionário 1");
            funcionario1.salario = double.Parse(Console.ReadLine());

            // Dados Funcionario 2 - Nome
            Console.WriteLine ("\n\n>> Nome do funcionário 2 :");
            funcionario2.nome = Console.ReadLine().ToLower();

            // Dados Funcionario 2 - Salario
            Console.WriteLine (">> Salário do funcionário 2");
            funcionario2.salario = double.Parse(Console.ReadLine());

            // Calcular e mostra a media
            media = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine ("\n\n>> A média dos salários é "+media+"\n\n");

            Console.ReadLine ();
        }
    }
}