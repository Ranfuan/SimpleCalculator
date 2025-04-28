using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        while (true)    // The entire app is wrapped in a "while" loop that is set to "true" by default.
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
                break;  //Exit the loop after successful calculation
              }
              catch (FormatException)
            {
               Console.WriteLine("Please enter only numeric values.");
            }
        }
    }
}