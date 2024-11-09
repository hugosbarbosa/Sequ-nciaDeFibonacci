using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequênciaDeFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.Write("Selecione a quantidade de valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Sequência de Fibonacci com " + valores + " valores:");

            Console.WriteLine();

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ",");

                }
                else
                {
                    Console.Write(a);
                }

                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
