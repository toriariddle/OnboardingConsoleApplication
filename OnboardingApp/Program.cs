using System;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var User = new User();
            Console.WriteLine("Hello and welcome to the Onboarding Application!");
            User.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Hello {User.FirstName}!");

            User.LastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Wonderful, hello {User.FullName}!");

            User.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine($"Cool, that's good to know! {User.IsAccountOwner}");

            User.PinNumber = AskIntQuestion("What is your 4 digit pin number?", 4);
            Console.WriteLine($"Your 4 digit pin is {User.PinNumber}");

            Console.WriteLine($"Excellent, thank you {User.FullName} for using the OnboardingApp!");
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

                if (response.ToLower() == "y")
                    return true;

                if (response.ToLower() == "n")
                    return false;

                if (response.ToLower() != "y")
                    Console.WriteLine("Invalid entry. Please type y or n");
            }
        }

        /// <summary>
        /// ask for users pin number via console
        /// </summary>
        /// <param name="question">What is your 4 digit pin number?</param>
        /// <param name="length">restrict to 4 digits</param>
        /// <returns>4 digit pin number</returns>

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

                Console.WriteLine($"Invalid entry. Must be a numeric value.");
            }
        }
    }
}