using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
             
                Console.Write("Enter first number (or 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                double num1 = double.Parse(input);

                
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

               
                Console.Write("Enter operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                
                double result = 0;

                if (operation == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please use +, -, *, or /");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("Goodbye!");
        }
    }
}