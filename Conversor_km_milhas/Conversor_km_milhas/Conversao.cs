using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversos_km_milhas
{
    internal class Conversao
    {
        private double milhas;
        private double resultado;


        public Conversao()
        {
            this.milhas = 0;
            this.resultado = 0;

        }

        public void setmilhas(double milhas)
        {
            this.milhas = milhas;
        }
        public double getmilhas()
        {
            return this.milhas;
        }
        public double getresultado()
        {
            return this.resultado;
        }

        public void Converter()
        {
            this.resultado = this.milhas*1.852;
        }
    }
}
