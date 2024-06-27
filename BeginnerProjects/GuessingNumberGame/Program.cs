using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guessingNum;
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            bool isCorrectGuess = false;

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");
            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess.");
                guessingNum = Convert.ToInt32(Console.ReadLine());
                
                if (guessingNum > 10 || guessingNum < 1)
                    Console.WriteLine("Number is out of range!");
                else if (guessingNum == randomNum)
                {
                    Console.WriteLine("You Won!");
                    isCorrectGuess = true;
                }
                else
                {
                    if(guessingNum > randomNum)
                        Console.WriteLine("Your guess is too high");
                    else
                        Console.WriteLine("Your guess is too low");
                }
                    
            }

            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
        }
    }
}
