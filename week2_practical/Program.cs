

using System;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Xml.Serialization;

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
            //task1 - 4
            //int option;
            //do
            //{
            //    PrintMenu();
            //    option = InputOption();
            //    Console.WriteLine(GetMessage(option));
            //    Console.ReadLine();
            //} while (option !=0);
            // task5- 9
            //Console.WriteLine("Enter a string:");
            //string string1 = Console.ReadLine();
            //Console.WriteLine("The sentence you inputted: ", string1);
            //Console.WriteLine("The number of words is ",CountWords(string1));
            //Console.Clear();
            //Console.WriteLine("Time for Julius encryption");
            //Console.WriteLine("Enter a string");
            //String input = Console.ReadLine();
            //Console.WriteLine("Number of rotations");
            //int key = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your encrypted text: ");
            //Console.WriteLine(Encrypt(input, key));
            //Console.WriteLine("Enter a string");
            //String input1 = Console.ReadLine();
            //Console.WriteLine("Number of rotations");
            //int key1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your decrypted text: ");
            //Console.WriteLine(Encrypt(input1, key1));
            //PrintMenu1();
            //int choice = Convert.ToInt32(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Enter a string");
            //        String input = Console.ReadLine();
            //        Console.WriteLine("Number of rotations");
            //        int key = Convert.ToInt32(Console.ReadLine());
            //        while (key<0 || key>100)
            //        {
            //            Console.WriteLine("Enter appropriate number of rotations");
            //            key = Convert.ToInt32(Console.ReadLine());
            //        }
            //        Console.WriteLine("The sentence you inputted: ", input);
            //        Console.WriteLine("Your encrypted text: ");
            //        Console.WriteLine(Encrypt(input, key)); ;
            //        break;
            //    case 2:
            //        Console.WriteLine("Enter a string");
            //        String input1 = Console.ReadLine();
            //        Console.WriteLine("Number of rotations");
            //        int key1 = Convert.ToInt32(Console.ReadLine());
            //        while (key1 < 0 || key1 > 100)
            //        {
            //            Console.WriteLine("Enter appropriate number of rotations");
            //            key1 = Convert.ToInt32(Console.ReadLine());
            //        }
            //        Console.WriteLine("The sentence you inputted: ", input1);
            //        Console.WriteLine("Your decrypted text: ");
            //        Console.WriteLine(Encrypt(input1, key1));
            //        break;
            //    case 0:
            //        Environment.Exit(0);
            //        break;
            //    default:
            //        Console.WriteLine ("Invalid choice. Please try again.");
            //        break;

            //}
            //task10
            int option1 = 0;
            do
            { 
                Console.WriteLine("pick an option");
                Console.WriteLine("1 - Circle Area");
                Console.WriteLine("0 - Exit");
                option1 = Convert.ToInt32(Console.ReadLine());
                if (option1 == 1)
                {
                    Console.WriteLine("Enter your radius for the circle");
                    double radius =Convert.ToDouble(Console.ReadLine());
                    double area = CircleArea(radius);
                    Console.WriteLine("Your area is "+  area);
                }

            } while (option1 != 0);
            Console.ReadLine();
        }
        static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
            
        }
        static void PrintMenu1()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Select an option!");
            Console.WriteLine("1 - encrypt text");
            Console.WriteLine("2 - decrypt text");
            Console.WriteLine("3 - end");
        }
        static int CountWords(string str)
        {
            int count = 0;
            foreach (char c in str)
            {   bool upper = Char.IsUpper(c);
                if (upper == true )
                {
                   count++;
                }
            }
            return count;
        }
        static String Encrypt(String str, int k)
        {
            String output = "";
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    char lowerc = char.ToLower(c) ;
                    char shifted = (char)(((lowerc + k - 'a') % 26) + 'a');
                    output += shifted;
                }
                else
                {
                    output += c;

                }
            }
            return output;
        }
        static String Decrypt(String str, int k)
        {
            String output = "";
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    char lowerc = char.ToLower(c);
                    char shifted = (char)(((lowerc - k - 'a' + 26) % 26) + 'a');
                    output += shifted;
                }
                else
                {
                    output += c;

                }
            }
            return output;
        }
        static void PrintMenu()
        {
                // Construct the menu
                Console.Clear();
                Console.WriteLine("Please enter a valid option from below");
                Console.WriteLine("1. Hello in French?");
                Console.WriteLine("2. Hello in Spanish");
                Console.WriteLine("3. Hello in German");
                Console.WriteLine("4. Hello in Italian");
                Console.WriteLine("0. Exit application");
                
        }
       static int InputOption()
        {
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error. {ex.Message}");
                return -1;
            }
            
        }
        static string GetMessage(int option)
        {
            switch (option)
            {
                case 1:
                    return ("Salut");
                case 2:
                    return("Hola");
                case 3:
                   return ("Hallo");
                case 4:
                    return("Ciao");
                case 0:
                    return("GOODBYE!");
                default:
                    return("Invalid choice. Please try again.");
                    
            }
            
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
