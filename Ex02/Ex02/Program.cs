using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Det första talet:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Det andra talet:");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            if(tal1 < tal2)
            {
                for (int i = tal1 + 1; i < tal2; i++)
                    Console.WriteLine(i);
            }
            else
            {
                for (int i = tal1 - 1; i > tal2; i--)
                    Console.WriteLine(i);
            }
        }
    }
}
