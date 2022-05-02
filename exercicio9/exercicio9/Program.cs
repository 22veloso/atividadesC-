//lucas veloso 3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, m = 0, y = 0;
            int n = 15;
            int[] v = new int[n];
            float preço, media = 0, x, maior = 0;
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("informe o preço do produto:R$");
                v[i] = int.Parse(Console.ReadLine());
                m++;
            }
            for (i = 0; i < 15; i++)
            {
                if (v[y] >= maior)
                {
                    maior = v[y];
                }
                x = (media + v[y]);
                media = x;
                y++;
            }
            media = media / 15;
            Console.WriteLine("a media do preço= "+ media + " e o maior preço=R$ "+ maior);
            Console.ReadKey();

        }
    }
}