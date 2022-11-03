using System;

namespace Cambio {
    class ConversoDeMoeda {
        public static double iof = 0.38;

        public static double DolarParaReal (double quantia, double cotacao){
            double total = quantia * cotacao;
            return total + total * iof / 100.0;
        }
    }
}