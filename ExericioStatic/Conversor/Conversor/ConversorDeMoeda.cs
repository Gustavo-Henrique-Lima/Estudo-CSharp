using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class ConversorDeMoeda
    {
        public static double iof = 0.06;

        public static double Converter(double cotacao, double qtd)
        {
            double ValorSemImposto = cotacao * qtd;
            return ValorSemImposto += ValorSemImposto * iof;

        }
    }
}
