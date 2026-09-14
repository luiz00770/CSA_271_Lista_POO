using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dólar_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversão valor = new Conversão();

            valor.setcot(Entrarint("Qual a cotação atual do dólar para o real? "));
            valor.setquant(Entrarint("Quanto dólares você quer converter? "));

            valor.Converter();
            Console.WriteLine("Você possui {0} reais com essa quantidade de dólares", valor.getresultado());
                

        }
        static double Entrarint(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}
