using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumberOk = false;
            while (!isNumberOk)
            {
                Console.WriteLine("Mata in ett tal: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if(input > 10)
                {
                    Console.WriteLine("Värdet är för högt.");
                    continue;
                }

                if(input < 10)
                {
                    Console.WriteLine("Värdet är för lågt.");
                    continue;
                }

                if(input == 10)
                {
                    Console.WriteLine("Du matade in rätt tal.");
                    isNumberOk = true;
                }

            }

        }
    }
}
