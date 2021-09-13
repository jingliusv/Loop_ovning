using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            const string username = "abc123";
            const string password = "password";

            bool infoOk = false;

            while (!infoOk)
            {
                Console.WriteLine("Ange användarnamn: ");
                string inputName = Console.ReadLine();

                Console.WriteLine("Ange löseord: ");
                string inputPass = Console.ReadLine();

                if(inputName == username && inputPass == password)
                {
                    Console.WriteLine("Du är inloggad.");
                    infoOk = true;
                }
                else
                {
                    if(inputName != username)
                        Console.WriteLine("Du har skrivit fel användarnamn.");
                    if(inputPass != password)
                        Console.WriteLine("Du har skrivit fel löseord.");

                    Console.WriteLine("Vill du försöka igen? (J/N)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "j")
                        continue;
                    else if(answer == "n")
                        infoOk = true;
                }
                    
            }

        }
    }
}
