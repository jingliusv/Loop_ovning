using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                    summa++;
                }                  
                else
                    continue;
            }
            Console.WriteLine($"{summa} tal");
        }
    }
}
