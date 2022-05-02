// lucas veloso RA 3319601
// media de filhos/porcentagem de salario/renda mensal 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma = 0;
            float renda = 0;
            int cont = 0;
            int maior = 0, menor = 150;
            double valorfinal = 0;
            int contador = 0;

            for (int d = 1; d < 5; d++)
            {
                Console.WriteLine("familia: " + d);
                Console.WriteLine("digite a renda mensal:");
                float salario = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a quantidade de filhos:");
                int qtfilho = int.Parse(Console.ReadLine());

                soma = qtfilho + soma;

                cont++;
                renda = salario + renda;
                if (salario < menor)
                {
                    contador++;
                    for (int i = 1; i < 5; i++)
                    {
                        valorfinal = (contador * 100) / i;
                    }
                }
                if (salario > maior)
                {
                    maior = (int)salario;
                }
            }
            Console.WriteLine("renda mensal das 4 familias sao: " + renda);
            Console.WriteLine("a media salarial por familia é: " + renda / cont);
            Console.WriteLine("a quantidade de filhos das 4 familias são:  " + soma);
            Console.WriteLine(" a media de filhos por familia: " + soma / cont);
            Console.WriteLine("o maior salario é: " + maior);
            Console.WriteLine("a porcentagem de pessoas que recebem menos que 150,00 reais sao: " + valorfinal + "%");

            Console.ReadLine();
        }
    }
}