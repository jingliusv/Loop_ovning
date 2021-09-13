using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for(int i = input - 1; i >= 0; i--)
                Console.WriteLine(i);
        }
    }
}
