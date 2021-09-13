using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepOn = true;

            while (keepOn)
            {
                Console.WriteLine("Det första talet: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Det andra talet: ");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Summan av två talen: {tal1 + tal2}");

                Console.WriteLine("Vill du fortsätta(J/N)?");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "J")
                    continue;
                else if(answer == "N") 
                    keepOn = false;
            }
        }
    }
}
