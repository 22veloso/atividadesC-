//exercicio5
//lucas veloso

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float pesom, pesof;

            Console.WriteLine("informe o nome do da pessoa :");
            String nome = (Console.ReadLine());
            Console.WriteLine("informe a altura:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o sexo('m' para masculino/ 'f' para feminino)");
            char sexo = char.Parse(Console.ReadLine());
            pesom = (float)((72.7 * altura) - 58);
            pesof = (float)((62.1 * altura) - 44.7);
            if (sexo == 'm')
            {
                Console.WriteLine("o peso ideal do " + nome + " é " + pesom);
            }
            else if (sexo == 'f') { 

                Console.WriteLine("o peso ideal da " + nome + " é " + pesof);
        }
       
            Console.ReadKey();
            }

        }

    }
