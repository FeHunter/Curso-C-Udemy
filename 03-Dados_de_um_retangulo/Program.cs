using System;
using System.Globalization;

namespace DadosRetangulo {
    class Program {
        static void Main (string[] args){
            Retangulo retangulo = new Retangulo ();

            // Inicio
            Console.WriteLine ();
            Console.WriteLine ("Calcular Área, Perímetro e Diagonal de um retangulo \n");
            Console.Write("Digite a largura: ");
            retangulo.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a altura: ");
            retangulo.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine ();

            // Área
            Console.WriteLine ("Área: " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            // Perímetro
            Console.WriteLine ("Perímetro: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            // Diagonal
            Console.WriteLine ("Diagonal: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}