//lucas veloso RA 3319601
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, soma = 0, maximo = 100;
            float media;
            for (i = 15; i < maximo + 1; i++)
            {
                soma = soma + i;
            }
            media = soma / 85;
           
            Console.WriteLine("a soma dos valores de 15 á 100 é: " + soma);

            Console.WriteLine("a media aritmética de 15 á 100 é de : " + media);
            Console.ReadKey();
        }
    }
}