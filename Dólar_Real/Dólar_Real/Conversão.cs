using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dólar_Real
{
    internal class Conversão
    {
        private double cot;
        private double quant;
        private double resultado;
        public Conversão()
        {
            this.cot = 0;
            this.quant = 0;
            this.resultado = 0;

        }

        public void setcot(double cot)
        { 
            this.cot = cot;
        }
        public void setquant(double quant)
        { 
            this.quant = quant;
        }
        public double getcot()
        {
            return this.cot;
        }
        public double getquant()
        {
            return this.quant;
        }
        public double getresultado()
        {
            return this.resultado;
        }

        public void Converter()
        { 
            this.resultado = this.cot*this.quant;
        }
    }
}
