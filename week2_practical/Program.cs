

using System;

namespace week2_practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //Console.WriteLine("Pick a number");
            //DoWhile1(Convert.ToInt32(Console.ReadLine()));
            //DebuggingExample();
            //CalculatorApp();
            //Console.ReadLine();
        }
        static void ForLoop()
        {
            // This program calculates and displays the squares of numbers from 10 to 500

            // Loop from 10 to 500
            for (int number = 10; number <= 500; number++)
            {
                // Calculate the square of the current number
                int square = number * number;

                // Display the result
                Console.WriteLine($"The square of {number} is {square}");
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void DoWhile1( int num)
        {
            int num1;
            do
            {
                Console.WriteLine("Enter a number (greater than 10 to quit): ");
                num1 = Convert.ToInt32(Console.ReadLine());
                // Loop will repeat until user inputs a number >10
            } while (num1 <= 10);

            Console.WriteLine($"You entered: {num1} which quit the program.");

        }
        static void DebuggingExample()
               {
                int number = 10;
                int result = number / 0;
                Console.WriteLine(number);
                   }
          static void CalculatorApp()
            {
            try
            {
                // Prompt the user to enter the first number
                Console.Write("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                // Prompt the user to enter the second number
                Console.Write("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                // Prompt the user to enter the operation
                Console.Write("Enter the operation (+, -, *, /): ");

                // Keyboard input is by default of type 'string'
                // and requires conversion to 'char' to work
                // with the switch statement
                char operation = Convert.ToChar(Console.ReadLine());
                int result = 0;

                // Perform the operation
                switch (operation)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        break;
                    case '/':
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                // Handle the case where the input is not valid
                Console.WriteLine("Please enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                // Handle the divide by zero error
                Console.WriteLine($"You cannot divide by zero.");
            }
            finally
            {
                // This block runs no matter what
                Console.WriteLine("Operation completed.");
            }
        }

    }
   
}
