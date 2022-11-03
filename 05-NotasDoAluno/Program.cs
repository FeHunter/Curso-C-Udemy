using System;
using System.Globalization;

namespace NotasDoAluno {
    class Program{
        static void Main (string[] args){

            Aluno aluno = new Aluno ();

            Console.WriteLine (); // Pular linha
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine (); // Pular linha
            Console.WriteLine("Digite as notas do aluno");
            Console.Write("1° Notas: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("2° Notas: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("3° Notas: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine (); // Pular linha
            Console.WriteLine ("Nota final = "+aluno.CalcularNota().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine (); // Pular linha
            Console.WriteLine(aluno.EstatosFinal());
            
            Console.ReadLine();
        }
    }
}