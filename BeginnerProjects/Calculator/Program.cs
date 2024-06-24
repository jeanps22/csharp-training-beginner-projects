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
            int num1;
            int num2;
            string operation;
            float result = 0;
            bool restart = false;

            Console.WriteLine("Hello, Welcome to the calculator program!");
            do
            {
                restart = false;
                Console.WriteLine("Please enter your first number.");
                Int32.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("Please enter your second number.");
                Int32.TryParse(Console.ReadLine(), out num2);

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Plese enter + for addition, - for subtraction, * for multiplication or / for division.");
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
                        if (num2 == 0)
                        {
                            Console.WriteLine("It is not possible to divide by zero! Try Again.");
                            restart = true;
                            break;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("No operation know");
                        restart = true;
                        break;
                }

                if (!restart)
                {
                    Console.WriteLine("The result is " + result);
                    Console.WriteLine("Do you want to continue? 'Y/N'");
                    restart = Console.ReadLine().ToUpper() == "Y";
                }
            } while (restart);

            Console.WriteLine("Thank you for using the calculator program!");
            Console.ReadKey();
        }
    }
}
