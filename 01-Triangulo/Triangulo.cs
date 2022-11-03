using System;
using System.Collections.Generic;
using System.Globalization;
using LerTriangulo;

namespace LerTriangulo {
    public class Triangulo {
        public double A, B, C;

        public double Area (){
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A)*(p - B)*(p - C));
        }
    }
}