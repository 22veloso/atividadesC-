//exercicio3
//lucas veloso

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float imposto, valorfinal, porcem = 73;
            Console.WriteLine("informe custo de fabrica:");
            float valorfabri = float.Parse(Console.ReadLine());
            imposto = (valorfabri * porcem) / 100;
            valorfinal = (valorfabri + imposto);

            Console.WriteLine("o valor final ao consumidor é "+ valorfinal+" reais" );

            Console.ReadKey();

        }

    }
}