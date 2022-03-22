//lucas veloso 3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
                Console.WriteLine(" Tres números:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
           

            int menor = a;
                int maior = a;
                if (b > maior)
                {
                    maior = b;
                }
                if (c > maior)
                {
                    maior = c;
                }
                if (b < menor)
                {
                    menor = b;
                }
                if (c < menor)
                {
                    menor = c;
                }
            
                Console.WriteLine(" Maior: " + maior + " Menor: " + menor);
           
            Console.ReadKey();
           
        }
    }
}