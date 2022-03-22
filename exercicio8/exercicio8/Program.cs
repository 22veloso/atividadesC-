//lucas veloso 3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("Digite tres valores: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Os 3 lados formam um triangulo!\n");
                if (a == b && a == c)
                {
                    Console.WriteLine("Equilatero\n");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Isosceles\n");
                }
                else
                {
                    Console.WriteLine("Escaleno\n");
                }
            }
            else
            {
                Console.WriteLine("Os 3 lados NAO formam um trinagulo!\n");
                
            }
            Console.ReadKey();

        }
    }
}