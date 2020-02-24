using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.decimalToBinary();
            p.decimalToOctagal();
            p.decimalToHexa();
            p.binaryToDecimal();

        }
        void decimalToBinary()
        {
            Console.WriteLine("Decimal to Binary Conversion");
            int deci = 10;
            Console.WriteLine("Decimal Number:" + deci);
            int[] c = new int[50];
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                c[i] = deci % 2;
                if (deci <= 1)
                {
                    break;
                }
                deci /= 2;
            }
            Console.WriteLine("Its Binary Equivalent Number:");
            int j = 0;
            for (j = i; j >= 0; j--)
            {
                Console.Write(c[j]);
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
        void decimalToOctagal()
        {
            Console.WriteLine("Decimal to Octagonal Conversion");
            int deci = 10;
            Console.WriteLine("Decimal Number:" + deci);
            int[] c = new int[50];
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                c[i] = deci % 8;
                if (deci < 7)
                {
                    break;
                }
                deci /= 8;
            }

            int j = 0;

            Console.Write("Its Ocatagal Equivalent Number:");
            for (j = i; j >= 0; j--)
            {
                Console.Write(c[j]);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }

        void decimalToHexa()
        {
            Console.WriteLine("Decimal to HexaDecimal Conversion");
            int deci = 10;
            Console.WriteLine("Decimal Number:" + deci);
            char[] c = new char[50];
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                int temp = 0;
                temp = deci % 16;
                if (temp < 10)
                {
                    c[i] = Convert.ToChar(temp + 48);
                }
                else
                {
                    c[i] = Convert.ToChar(temp + 55);
                }
                if (deci < 15)
                {
                    break;
                }
                deci = deci / 16;
            }
            int j = 0;
            Console.Write("Its HexaDecimal Equivalent Number:");
            for (j = i; j >= 0; j--)
            {
                Console.Write(c[j]);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }

        void binaryToDecimal()
        {
            Console.WriteLine("Binary to Decimal Conversion");
            int num, bin, deci = 0, baseval = 1, rem;
            num = 1010;
            bin = num;
            while (num > 0)
            {
                rem = num % 10;
                deci = deci + rem * baseval;
                num = num / 10;
                baseval = baseval * 2;
            }
            Console.Write("Binary Number: " + bin);
            Console.Write("\nIts Decimal Equivalent Number: " + deci);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }

    }
}
