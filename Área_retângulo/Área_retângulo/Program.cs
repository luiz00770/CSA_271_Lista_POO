using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_retângulo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Área ret = new Área();

            ret.setbase(EntrarInt("Digite o valor de base do retângulo: "));
            ret.setaltura(EntrarInt("Digite o valor da altura do retângulo: "));

            ret.Calcular();
            Console.WriteLine("A área do retângulo é: {0}",
                ret.getresultado());
        }

        static int EntrarInt(string mensagem)
        { 
            Console.Write(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }
}
