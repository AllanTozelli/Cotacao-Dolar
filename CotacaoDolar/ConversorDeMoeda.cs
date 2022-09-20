using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double ValorEmDolar;
        public static double IOF = 0.06;

        public static double ValorPago()
        {
            return Cotacao * (ValorEmDolar + (ValorEmDolar * IOF));
        }
    }
}
