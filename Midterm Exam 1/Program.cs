// Noah Pascual
// MIS 3033
// Midterm One - Task One

// Instructions:
// Create a console application that can help use calculate the result of an equation. 
// Create the Equation class according to the UML below
// The app first asks the user to input the values for Left and Right.
// Once they have input the values, ask which calculation they wish to perform (add, subtract, multiply, or power).
// If they choose to apply a Power to either the Left or Right, call the appropriate method after asking them to which power they wish to raise the operand to (left to the power (L) or right to the power (R)). 
// You can use Math.Pow() to calculate power. Calculate their results and build a string and add it to a List object
// Once you have stored the results, ask the user if they wish to input another equation
// If they say Yes or Y, repeat the process until they say No or N.
// Once they have finished inputting all of their equations, use a For Each loop to iterate through your List object and output all of the strings to the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Main variables
            string userInput;

            // int addition = 0;
            // int subtraction = 0;
            // int multiplication = 0;
            // int leftPwrRight = 0;
            // int rightPwrLeft = 0;

            string userEnd;
            // Call to class
            Equation equation = new Equation();
            // List for calculations
            List<Equation> equations = new List<Equation>();

            // Title (Midterm)
            string title = "--- Midterm One: Task One ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Ask user for a number for Left and Right
            Console.WriteLine("Please enter a (left) number >>>");
            equation.Left = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a (right) number >>>");
            equation.Right = Convert.ToDouble(Console.ReadLine());
            do
            {
                // Ask the user what type of calculation they would like to do
                Console.WriteLine("\nWhat calculation would you like to perform? Press \"1 through 5\". If you are finding your calculations, Press \"ENTER\" >>>" +
               "\n\t1.) Addition" +
               "\n\t2.) Subtraction" +
               "\n\t3.) Multiplication" +
               "\n\t4.) Left number to the power of right number" +
               "\n\t5.) Right number to the power of left number)");
                userInput = Console.ReadLine().Trim();

                if (userInput.Equals("1"))
                {
                    // addition = Convert.ToInt32(ReadLine());
                    Console.WriteLine($"The sum of the numbers is: {equation.Add()}");
                }
                else if (userInput.Equals("2"))
                {
                    // subtraction = Convert.ToInt32(ReadLine());
                     Console.WriteLine($"The difference of the numbers is: {equation.Subtract()}");
                }
                else if (userInput.Equals("3"))
                {
                    // multiplication = Convert.ToInt32(ReadLine());
                    Console.WriteLine($"The product of the numbers is: {equation.Multiply()}");
                }
                else if (userInput.Equals("4"))
                {
                    // leftPwrRight = Convert.ToInt32(ReadLine());
                    Console.WriteLine($"{equation.Left} to the power of {equation.Right} is: {equation.LeftToThePower(power: (int)equation.Right)}");
                }
                else if (userInput.Equals("5"))
                {
                    // rightPwrLeft = Convert.ToInt32(ReadLine());
                    Console.WriteLine($"{equation.Right} to the power of {equation.Left} is: {equation.RightToThePower(power: (int)equation.Left)}");
                }
                else
                {
                    // Validate user is using correct options
                    Console.WriteLine("*** That is an invalid answer, Please anser with either 1, 2, 3, or 4 ***");
                }

                // Ask user if they would like to see another type of calculation
                Console.WriteLine("Do you want to see another calculation? Please enter Yes/Y or No/N>>");
                 userEnd = Console.ReadLine().ToLower();

                // If statement to end application
                if (userEnd == "n" || userEnd == "no")
                {
                    break;
                }

                // do-while to restart the loop if user would like to ask for more calculations
            } while (userEnd == "yes" || userEnd == "y");

            // Exit
            Console.WriteLine("\n\rPress any key to exit the application.");

            //Readkey
            Console.ReadKey();

        }
    }
}
