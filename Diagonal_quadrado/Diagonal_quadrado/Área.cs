using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_quadrado
{
    internal class Área
    {
        private double diag;
        private double resultado;

        public Área()
        {
            this.diag = 0;
            this.resultado = 0;
        }

        public Área(double diag, double resultado)
        {
            this.diag = diag;
            this.resultado = 0;
        }

        public void SetDiag(double diag)
        {
            this.diag = diag;
        }
        public double GetAresta()
        {
            return this.diag;
        }

        public double GetResultado()
        {
            return resultado;
        }

        public void Calcular()
        {
            this.resultado = Math.Sqrt(this.diag) * Math.Sqrt(this.diag);
        }
    }
}
