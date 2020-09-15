using System;

namespace Week3_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // going over homework 2
            String firstName; // = "Mark";
            String lastName; // = "Aloka";
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            // firstName = firstName.ToLower();
            // lastName = lastName.ToLower();
            String piglatinFirstName;             // 0123
            String piglatinLastName;              // Mark
            piglatinFirstName = firstName.Substring(1, firstName.Length - 1) +
                firstName.Substring(0, 1).ToLower() + "ay"; // arkmay
            piglatinFirstName = piglatinFirstName.Substring(0, 1).ToUpper() +
                piglatinFirstName.Substring(1, piglatinFirstName.Length - 1);
                // Arkmay
            piglatinLastName = lastName.Substring(1, lastName.Length - 1) +
               lastName.Substring(0, 1).ToLower() + "ay";
            piglatinLastName = piglatinLastName.Substring(0, 1).ToUpper() +
                piglatinLastName.Substring(1, piglatinLastName.Length - 1);

            Console.WriteLine("Your name in pig latin is: " + piglatinFirstName
                + " " + piglatinLastName);
            */

            // introduction to methods
            String firstName; // = "Mark";
            String lastName; // = "Aloka";
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            printPigLatinName(firstName, lastName);
        }

        // static: accessible to other static methods
        // void: this method does not return anything
        // function name(type parameter): parameter is a local variable
        static void printPigLatinName(String firstName, String lastName)
        {
            String piglatinFirstName;
            String piglatinLastName;

            piglatinFirstName = firstName.Substring(1, firstName.Length - 1) +
                firstName.Substring(0, 1).ToLower() + "ay";
            piglatinFirstName = piglatinFirstName.Substring(0, 1).ToUpper() +
                piglatinFirstName.Substring(1, piglatinFirstName.Length - 1);

            piglatinLastName = lastName.Substring(1, lastName.Length - 1) +
               lastName.Substring(0, 1).ToLower() + "ay";
            piglatinLastName = piglatinLastName.Substring(0, 1).ToUpper() +
                piglatinLastName.Substring(1, piglatinLastName.Length - 1);

            Console.WriteLine("Your name in pig latin is: " + piglatinFirstName
                + " " + piglatinLastName);
        }
    }
}