using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area tri = new Area();

            tri.setbaze(entrarDouble("Digite a base do triângulo: "));
            tri.setaltura(entrarDouble("Digite a altra do triângulo: "));

            tri.Calcular();
                Console.WriteLine("A área do triângulo é de: {0}",
                    tri.getresultado());

        }

        static double entrarDouble(string mensagem)
        { 
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}
