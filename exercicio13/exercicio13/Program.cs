//lucas veloso RA 3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("informe um valor MAIOR que zero:");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int i;
                for (i = 1; i < n + 1; i++)
                {
                    Console.WriteLine("os nomeros são: " + i);
                }
            }
            else
            {Console.WriteLine("o numero precisa ser maior que zero!!");
            }
            Console.ReadKey();
        }

    }
}