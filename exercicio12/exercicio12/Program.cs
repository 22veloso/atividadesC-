// lucas velos RA:3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma = 0;
            int n = 11;
            int[] v = new int[n];
            int i;
            for (i = 1; i < 11; i++)
            {
                Console.WriteLine("digite o valor " + i + ":");
                v[i] = int.Parse(Console.ReadLine());
                soma = soma + v[i];
            }

            Console.WriteLine("a soma dos valores é " + soma);
            Console.ReadKey();
        }
    }
}

