using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        bool keepRunning = true;
        while (keepRunning)    // The entire app is wrapped in a "while" loop that is set to "true" by default.
        {
            try
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                if (op == "+")
                    result = num1 + num2;
                else if (op == "-")
                    result = num1 - num2;
                else if (op == "*")
                    result = num1 * num2;
                else if (op == "/")
                {
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        continue;   //Restart the loop
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operator.");
                    continue;   //Restart the loop
                }
            
                Console.WriteLine("Result: " + result);
                //Ask the user if they want to continue
                Console.Write("Would you like to perform another calculation? (y/n): ");
                string answer = Console.ReadLine().ToLower();  // Creates a string called "answer" and sets the value to whatever the user input in lowercase.
               
                if (answer != "y'" && answer != "yes")  //Checks if the user input "y" or "yes". If not, then boolean "keepRunning is set to false and ends loop.
                {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the calculator");
                }
              }
              catch (FormatException)
            {
               Console.WriteLine("Please enter only numeric values.");
            }
        }
    }
}