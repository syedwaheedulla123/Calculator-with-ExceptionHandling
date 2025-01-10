using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            string operation;

            try
            {
                // Input for the first number
                Console.WriteLine("Please enter first number:");
                num1 = Convert.ToDouble(Console.ReadLine());

                // Input for the second number
                Console.WriteLine("Please enter second number:");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Input for the operation
                Console.WriteLine("Choose the operation (+, -, *, /, %): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        // Division by zero exception handling
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            throw new DivideByZeroException("Error: Division by zero is not allowed.");
                        }
                        break;

                    case "%":
                        result = num1 % num2;
                        break;

                    default:
                        Console.WriteLine("Invalid operation! Please choose a valid option.");
                        return;
                }

                // Display result
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input format: {ex.Message}. Please enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
