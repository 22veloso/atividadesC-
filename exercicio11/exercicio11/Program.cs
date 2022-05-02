// lucas veloso RA3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;
            int[] v = new int[n];
            int i = 0, cont = 0;
            double somatemp = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Informe a temperatura do dia "+ (i + 1)+ " : ");
                v[i] = int.Parse(Console.ReadLine());
                somatemp = v[i] + somatemp;
                cont++;

            }
            Console.WriteLine("a media de temperatura em 5 dias  é: " + somatemp / cont + "°");
            Console.ReadKey();
        }

    }
}