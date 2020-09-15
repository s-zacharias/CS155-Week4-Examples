using System;

namespace Lecture3_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Expressions - relational operator
            // >, <, >=, <=, ==, !=
            /*
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);
            Console.WriteLine(x == 10);
            Console.WriteLine(15 < 10);
            */

            // Logical Operator
            // &&, ||, !


            // Conditional Statements
            // If Statement
            /*
            if (condition)
            {
                // block of code is executed if the condition is True
            }
            
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
            */

            // If-Else Statement
            /*
             if (condition)
             {
                 // block of code to be executed if the condition is True
             }
             else
             {
                 // block of code to be executed if the condition is False
             }
           
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            */

            // Short Hand If ... Else (Ternary Operator)
            /*
            int time = 20;
            String result = (time < 18) ? "Good Day." : "Good Evening.";
            Console.WriteLine(result);
            */

            // Indenting
            // Nested If
            /*
            int x;
            Console.WriteLine("Enter integer number: ");
            x = Int32.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("x is zero");
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine("x is positive");
                }
                else
                {
                    Console.WriteLine("x is negative");
                }
            }
            */

            // Multiway if-else statement - relational operators
            /*
            int score;
            Console.WriteLine("Enter your score: ");
            score = Int32.Parse(Console.ReadLine());
            if (score < 60)
            {
                Console.WriteLine("You need to do better next exam.");
            }
            else if (score < 75)
            {
                Console.WriteLine("You are passing so far.");
            }
            else if (score < 90)
            {
                Console.WriteLine("You are doing well.");
            }
            else
            {
                Console.WriteLine("Excellent work! Keep it up!");
            }
            */

            // Switch Statements
            /*
            int day;
            Console.WriteLine("Enter a number between 1 and 7: ");
            day = Int32.Parse(Console.ReadLine());
            switch(day)
            {
                case 1:
                    Console.WriteLine("The number you entered represents Monday.");
                    break;
                case 2:
                    Console.WriteLine("The number you entered represents Tuesday.");
                        break;
                case 3:
                    Console.WriteLine("The number you entered represents Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("The number you entered represents Thursday.");
                    break;
                case 5:
                    Console.WriteLine("The number you entered represents Friday.");
                    break;
                case 6:
                    Console.WriteLine("The number you entered represents Saturday.");
                    break;
                case 7:
                    Console.WriteLine("The number you entered represents Sunday.");
                    break;
                default:
                    Console.WriteLine("The number you entered is not valid.");
                    break;
            }
            */

            // Multiway with Logical Expressions
            /* 
            int age;
            Console.WriteLine("Enter your age: ");
            age = Int32.Parse(Console.ReadLine());
            if (age >= 18 && age < 26)
            {
                Console.WriteLine("Your age is between 18 and 25.");
            }
            else if (age > 25 && age < 35)
            {
                Console.WriteLine("Your age is between 26 and 35");
            }
            else if (age >= 36 && age < 50)
            {
                Console.WriteLine("Your age is between 36 and 50.");
            }
            else
            {
                Console.WriteLine("Your age is over 50.");
            }
            */
        }
    }
}
