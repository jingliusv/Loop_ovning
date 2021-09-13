using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0, tal = 0;
            for(int i = 265; i <= 290; i++)
            {
                if(i % 2 == 0)
                {
                    summa += i;
                    tal++;
                }
            }
            Console.WriteLine("Summa är " + summa + ".\nMedelvärdet: " + summa/tal);
        }
    }
}
