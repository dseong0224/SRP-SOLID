using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidatorErrorFor(string fieldName)
        {
            Console.WriteLine($"{fieldName} missing!");
        }
    }
}
