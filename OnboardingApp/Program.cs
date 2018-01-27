using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Onboard Application!");
            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("Great, hello" + firstName + "!");

            Console.WriteLine("What is your last name?");
            var lastName = Console.ReadLine();
            Console.WriteLine("Great, hello" + lastName + "!");
        }
    }
}
