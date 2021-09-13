using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Mata in ett tal:");
                int input = Convert.ToInt32(Console.ReadLine());
                summa += input;
            }

            Console.WriteLine($"Summan av det du matat in är: {summa}.");    
        }
    }
}
