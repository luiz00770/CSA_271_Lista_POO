using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior num = new Maior();

            num.setn1(msg("Digite o primeiro número: "));
            num.setn2(msg("Digite o segundo número: "));

            num.Comparar();
            Console.WriteLine("{0}", num.getresultado());

        }

        static double msg(string msg)
        { 
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }
    }
}
