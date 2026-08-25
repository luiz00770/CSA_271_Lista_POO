using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Área quad = new Área();

            quad.SetDiag(EntrarInt("Digite o valor da aresta do quadrado: "));

            quad.Calcular();
            Console.WriteLine("A área do quadrado é: {0}",
                quad.GetResultado());
        }

        static int EntrarInt(string mensagem)
        {
            Console.Write(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }

}
