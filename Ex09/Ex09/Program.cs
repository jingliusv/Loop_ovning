using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "", address = "", postnumber = "", place = "";

            bool running = true;

            while (running)
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Namn: ");
                    name = Console.ReadLine();
                }
                if (string.IsNullOrEmpty(address))
                {
                    Console.WriteLine("Gatuadress: ");
                    address = Console.ReadLine();
                }
                if (string.IsNullOrEmpty(postnumber))
                {
                    Console.WriteLine("Postnummer: ");
                    postnumber = Console.ReadLine();
                }
                if (string.IsNullOrEmpty(place))
                {
                    Console.WriteLine("Postort");
                    place = Console.ReadLine();
                }

                bool infoEmpty = string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(postnumber) || string.IsNullOrEmpty(place);


                if (infoEmpty)
                    continue;
                else
                {
                    Console.WriteLine("Alla uppgifter ifyllda.");
                    running = false;
                }
            }          
        }

    }
}
