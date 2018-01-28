using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var User = new User();
            Console.WriteLine("Hello and welcome to the Onboard Application!");
            User.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Great, hello {User.FirstName}!");

            User.LastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Great, hello {User.FullName}!");

            User.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine($"Cool, good to know. {User.IsAccountOwner}");

            User.PinNumber = AskIntQuestion("What is your 4 digit pin number?", 4);
            Console.WriteLine($"Cool, your 4 digit pin is {User.PinNumber}");
            Console.WriteLine("Thank you and have a wonderful day!");

            Console.ReadLine();
        }

        /// <summary>
        /// Ask question to the user via the console to get a response
        /// </summary>
        /// <param name="question">The question to ask the user</param>
        /// <returns>Response from the user</returns>

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        /// <summary>
        /// Ask true/false question to the user via console and get a response
        /// </summary>
        /// <param name="question">y / n</param>
        /// <returns>y/n</returns>

        static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var response = AskQuestion(question + "| (y/n)");
                switch (response.ToLower())
                {
                    case "y": return true;
                    case "n": return false;
                }
                Console.WriteLine("Invalid entry. Please type y or n");
                return response == "y";
            }
        }

        /// <summary>
        ///  Ask user for pin number via console and get a response
        /// </summary>
        /// <param name="question">What is your Pin Number</param>
        /// <param name="length">Restrict to 4 digits</param>
        /// <returns>4 Digit Numeric Pin Number </returns>

        static int AskIntQuestion(string question, int length = 0)
        {
            while (true)
            {
                var response = AskQuestion(question);

                if (length > 0 && length != response.Length)
                {
                    Console.WriteLine($"Invalid entry. Must be {length} digits.");
                    continue;
                }

                if (int.TryParse(response, out var value))
                {
                    return value;
                }

                Console.WriteLine($"Invalid entry. Must be numeric values.");
            }
        }
    }
}