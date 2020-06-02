/*Prompt a user to input his/her name and country name 
 * and then the output will be shown as an example below: 
 * Hello Ram from country India!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            do
            {
                Console.Write("Enter your name:");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"));
            do
            {
                Console.Write("Enter your country:");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country, @"^[a-zA-Z]+$"));
            Console.WriteLine("Hello " + name + " from country " + country);
            Console.Read();
        }
    }
}
