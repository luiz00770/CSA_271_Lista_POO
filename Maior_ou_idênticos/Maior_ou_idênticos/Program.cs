using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maior_ou_idênticos
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Maior n = new Maior();

            n.setn1(msg("Digite o primeiro número: "));
            n.setn2(msg("Digite o segundo número: "));

            n.Comparar();
            if (n.getresultado() == 1)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            if (n.getresultado() == 2)
            {
                Console.WriteLine("O segundo número é maior");
            }
            if (n.getresultado() == 3)
            {
                Console.WriteLine("Os dois números são idênticos");
            }



        }
        static double msg(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }

    }
}
