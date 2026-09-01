using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    internal class Maior
    {
        private double n1;
        private double n2;
        private string resultado;



        public Maior()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.resultado = "";

        }

        public void setn1(double n1)
        {
            this.n1 = n1;
        }
        public void setn2(double n2)
        {
            this.n2 = n2;
        }
        public double getn1()
        {
            return this.n1;
        }
        public double getn2()
        {
            return this.n2;
        }

        public string getresultado()
        {
            return this.resultado;
        }

        public void Comparar()
        {
            if (this.n1 > this.n2)
            {
                this.resultado = "O primeiro número é maior que o segundo";
            }
            else
            {
                if (this.n2 > this.n1)
                {
                    this.resultado = "O segundo número é maior queo primeiro";
                }
                else
                {
                    this.resultado = "Eles são iguais";
                }

            }
        }
    }
}

