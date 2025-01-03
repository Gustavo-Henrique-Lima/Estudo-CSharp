using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Reta
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double c = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            return Math.Sqrt(c);
        }
    }
}
