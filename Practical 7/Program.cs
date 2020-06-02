﻿/* 
 * C# code to Convert following currency conversion. 
 *-Rupees to dollar
 *-Rupees to frank
 *-Rupees to euro
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rupees, dollor, frank, euro;
            Console.Write("Enter amount in INR: ");
            rupees = decimal.Parse(Console.ReadLine());
            //Conversion of rupees to dollor
            dollor = 0.0139531M * rupees;
            //conversion from rupees to frank
            frank = 0.0135894M * rupees;
            //conversion from rupees to euro
            euro = 0.0127937M * rupees;
            Console.WriteLine($"INR{rupees} = {dollor.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"INR{rupees} = {frank.ToString("C", new CultureInfo("de-CH"))}");
            Console.WriteLine($"INR{rupees} = {euro.ToString("C", new CultureInfo("en-GB"))}");
            Console.Read();
        }
    }
}
