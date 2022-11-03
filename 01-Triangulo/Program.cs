/* Metodo sem programação orientação a objeto */
using System;
using System.Collections.Generic;
using System.Globalization;
using LerTriangulo;

namespace LerTriangulo {
    class Programa {
        static void Main (string[] args){

            Triangulo x, y;
            x = new Triangulo ();
            y = new Triangulo ();

            Console.WriteLine ("Digite os valores do triangulo X:");
            // Pegar valores do X
            x.A = double.Parse(Console.ReadLine().ToLower(), CultureInfo.InvariantCulture );
            x.B = double.Parse(Console.ReadLine().ToLower(), CultureInfo.InvariantCulture );
            x.C = double.Parse(Console.ReadLine().ToLower(), CultureInfo.InvariantCulture );

            Console.WriteLine ("Digite os valores do triangulo Y:");
            // Pegar valores do Y
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            double areaX = x.Area();
            double areaY = y.Area();
            
            Console.WriteLine("Area de X = "+ areaX.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("Area de Y = "+ areaY.ToString("F4", CultureInfo.InstalledUICulture));

            // Verificar quem tem maior area
            if (areaX > areaY){
                Console.WriteLine("Maior Area e do X");
            }else if (areaX < areaY){
                Console.WriteLine("Maior Area e do Y");
            }else if (areaX == areaY){
                Console.WriteLine("As medidas são iguais");
            }
        }
    }
}