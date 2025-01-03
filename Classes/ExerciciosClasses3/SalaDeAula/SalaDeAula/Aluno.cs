using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeAula
{
    class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public string CalcularMedia()
        {
            double media = Nota1  +Nota2 + Nota3;
            if (media >= 60)
            {
                return $"NOTA FINAL = {media.ToString("F2",CultureInfo.InvariantCulture)}\nAPROVADO";
            }
            else
            {
                return $"NOTA FINAL = {media.ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTARAM {(60-media).ToString("F2",CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
