using System;
using System.Globalization;

namespace Cambio {
    class Program{
        static void Main (string[] args){

            Console.WriteLine();
            Console.Write("Digite a cotação do dóla: ");
            double ctc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.Write("Quantos dólas você vai comprar? ");
            double qta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("O valor a ser pago em reais = "+ ConversoDeMoeda.DolarParaReal(qta, ctc).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}