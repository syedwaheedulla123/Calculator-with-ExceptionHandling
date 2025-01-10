using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string operation;

            // Get first number
            Console.WriteLine("Please enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Get second number
            Console.WriteLine("Please enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Get the operation
            Console.WriteLine("Choose the operation (+, -, *, /, %): ");
            operation = Console.ReadLine();

            try
            {
                // Perform the calculation based on the operation chosen
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
                        // Try to divide and catch any division by zero exceptions
                        result = num1 / num2; // If num2 is zero, this will throw DivideByZeroException
                        break;
                    case "%":
                        result = num1 % num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                // Output the result
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the calculator.");
            }
        }
    }
}
