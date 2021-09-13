using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal: ");
            string input = Console.ReadLine();
            Console.WriteLine("----------");

            if(Int32.TryParse(input, out int num))
            {
                if(num > 30)
                    Console.WriteLine("Du har matat in ett felaktigt tal.");
                else
                {
                    for(int i = num + 1; i <= 30; i ++)
                        Console.WriteLine(i);
                }
            }           
            else
                Console.WriteLine("Du har matat in ett ogiltigt tal.");

        }
    }
}
