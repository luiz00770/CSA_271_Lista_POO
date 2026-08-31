using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Área_triângulo
{
    internal class Area
    {
        private double baze;
        private double altura;
        private double resultado;


        public Area()
        {
            this.baze = 0;
            this.altura = 0;
            this.resultado = 0;

        }

        public void setbaze(double baze)
        { 
            this.baze = baze;
        }
        public void setaltura(double altura)
        {
            this.altura = altura;
        }
        public double getbaze()
        {
            return this.baze; 
        }
        public double getaltura() 
        {
            return this.altura;        
        }
        public double getresultado()
        {
            return this.resultado; 
        }

        public void Calcular()
        {
            this.resultado = (this.baze * this.altura) / 2;
        }
    }
}
