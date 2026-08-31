using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversos_km_milhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversao valor = new Conversao();

            valor.setmilhas(Msg("Digite a distância em milhas: "));

            valor.Converter();
                Console.WriteLine("O valor em quilômetros dessa distância é de: {0}km",
                    valor.getresultado());

        }
        static double Msg(string msg)
        { 
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }
    }
}
