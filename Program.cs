using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        bool keepRunning = true;

        while (keepRunning)    // Main program loop
        {
            double num1 = GetInput("Enter first number: ");     // First user input number.
            string op = GetOperator();                          // The operator the user specifies (+, -, *, /)
            double num2 = GetInput("Enter second number: ");    // Second user input number.

            double result;
            bool success = Calculate(num1, num2, op, out result);   //Performs the calculation

            if (success)
            {
                Console.WriteLine("Result: " + result);
            }

            keepRunning = DisplayMenu();        // As user if they want to continue.
        }

        Console.WriteLine("Thank you for using the calculator");
    }
        static double GetInput(string prompt)       // Function gets a valid number input from the user.
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))     // Tries to parse the user input into a double.
                {
                    return number;      // If successfully parsed, returns the number.
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }
        static string GetOperator()     // Function to get a valid operator input from the user.
        {
            while (true)
            {
                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                if (op == "+" || op == "-" || op == "*" || op == "/")   // Checks to see if operator is valid.
                {
                    return op;      // If valid, returns the operator.
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please enter one of +, -, *, /, ");
                }
            }
        }
        static bool Calculate(double num1, double num2, string op, out double result)       // Function to perform the calculation.
        {
            result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    return true;
                case "-":
                    result = num1 - num2;
                    return true;
                case "*":
                    result = num1 * num2;
                    return true;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");     // Error message displayed if user attempts to divide  by zero.
                        return false;
                    }
                default:
                    Console.WriteLine("Unkown operator.");
                    return false;
            }
        }
        static bool DisplayMenu()       // Function to display the menu and asks if the user wants to continue.
        {
            Console.Write("Do you want to perform another calculation? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            return (answer == "y" || answer == "yes");  // Returns true if user inputs "y" or "yes", otherwise returns false.
        }
    }
           