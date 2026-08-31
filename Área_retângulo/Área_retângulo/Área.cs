using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Área
    {
        private int baze;
        private int altura;
        private int resultado;


        public Área()
        {
            this.baze = 0;
            this.altura = 0;
            this.resultado = 0;
        }

        public void setbase(int baze)
        {
            this.baze = baze;
        }
        public void setaltura(int altura)
        {
            this.altura = altura;
        }
        public int getbase()
        {
            return this.baze;
        }
        public int getaltura()
        {
            return this.altura;

        }
        public int getresultado()
        {
            return this.resultado;

        }

        public void Calcular()
        {
            this.resultado = this.baze * this.altura;

        }
    }
}
