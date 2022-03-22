
//exercicio4
//lucas veloso

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float porcem, novosalario, salariofixo = 2000, comissao = 400;


            Console.WriteLine("Informe o nome do funcionario(a)/  Total de veiculos vendidos/  Valor total das vendas:");
            String nome = (Console.ReadLine());
            int carro = int.Parse(Console.ReadLine());
            float totalvendas = float.Parse(Console.ReadLine());
            porcem = (totalvendas * 5) / 100;
            novosalario = salariofixo + (carro * comissao) + porcem;

            Console.WriteLine("o novo salario do funcionario(a) é " + nome  +  novosalario + " reais");

            Console.ReadKey();

        }
    }
}
