using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeJurosCompostos0
{
    internal class Calc
    {

        public double ValorInicial { get; set; }
        public double ValorMensal { get; set; }
        public int TempoEmMeses { get; set; }
        public double Juros { get; set; }

        public double CalcularValorFinal()
        {
            double taxaJurosMensal = Math.Pow((1 + Juros), (1.0 / 12.0)) - 1;
            double fvInicial = ValorInicial * Math.Pow((1 + taxaJurosMensal), TempoEmMeses);

            double fvAportes = 0;
            if (taxaJurosMensal > 0)
            {
                fvAportes = ValorMensal * ((Math.Pow((1 + taxaJurosMensal), TempoEmMeses) - 1) / taxaJurosMensal);
            }
            else 
            {
                fvAportes = ValorMensal * TempoEmMeses;
            }

           
            double fvTotal = fvInicial + fvAportes;

            return fvTotal;


        }

    }
    
}
