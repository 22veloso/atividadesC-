//lucas veloso 3319601

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float salario_abaixo, salario_acima, resto, cond = 1500;


            Console.WriteLine("informe o nome do funcionario(a)/ valor do salario fixo/total de vendas:");
            String nome = (Console.ReadLine());
            float salario_fixo = float.Parse(Console.ReadLine());
            float venda_total = float.Parse(Console.ReadLine());
            salario_abaixo = ((venda_total * 3) / 100) + salario_fixo;
            resto = (venda_total - cond);
            salario_acima = (venda_total * 3) / 100 + (resto * 5) / 100 + salario_fixo;
            if (venda_total <= cond)
            {
                Console.WriteLine("o salario do vendedor(a) " + nome + " é " + salario_abaixo);
            }
            else
            {
                Console.WriteLine("o salario do vendedor(a) " + nome + " é " + salario_acima);

            }
            Console.ReadKey();
        }

    }
}
