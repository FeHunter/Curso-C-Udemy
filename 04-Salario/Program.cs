using System;
using System.Globalization; 

namespace Salario{
    class Program{
        static void Main (string[] args){
            
            Funcionario fun = new Funcionario ();

            Console.WriteLine (); // Pular linha
            Console.WriteLine("Informações sobre o salário");
            Console.WriteLine (); // Pular linha

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.WriteLine (); // Pular linha

            Console.Write("Salário brunto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine (); // Pular linha

            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine (); // Pular linha

            Console.WriteLine ("Funcionário: " + fun.ToString());
            Console.WriteLine (); // Pular linha

            Console.Write ("Digite a % 'porcentagem' para aumentar o salário: ");
            double por = double.Parse(Console.ReadLine());
            fun.AumentoSalario(por);
            Console.WriteLine (); // Pular linha

            Console.WriteLine ("Dados atualizados: " + fun.ToString());
            Console.WriteLine (); // Pular linha
        }
    }
}