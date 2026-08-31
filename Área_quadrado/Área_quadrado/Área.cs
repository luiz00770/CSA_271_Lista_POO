using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Área
    {
        private int aresta;
        private int resultado;

        public Área()
        {
            this.aresta = 0;
            this.resultado = 0;
        }

        public void SetAresta(int aresta)
        {
            this.aresta = aresta;
        }
        public int GetAresta()
        {
            return this.aresta;
        }

        public int GetResultado()
        {
            return resultado;
        }

        public void Calcular()
        {
            this.resultado = this.aresta * this.aresta;
        }
    }
}
