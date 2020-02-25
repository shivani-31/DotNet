using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern1();
            Pattern2();
            Pattern3();
            Pattern4();
            Console.Read();
        }
        private static void Pattern4()
        {
            Console.WriteLine("Pattern 4");
            int i, j, k = 4;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write(" ");

                k--;

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            k = 1;

            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write(" ");

                k++;

                for (j = 1; j <= 2 * (5 - i) - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        private static void Pattern3()
        {
            Console.WriteLine("Pattern 3");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j >= i)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }

        private static void Pattern2()
        {
            Console.WriteLine("Pattern 2");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Pattern1()
        {
            Console.WriteLine("Pattern 1");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
