using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enemyPoints = 0;
            int playerPoints = 0;
            int enemyChoice = 0;
            string playerChoice;
            Random rdm = new Random();

            Console.WriteLine("Welcome to the Rock Paper Scissors Game!");

            while (enemyPoints != 3 && playerPoints != 3)
            {
                Console.WriteLine("Please, enter 'r' for rock, 'p' for paper and anything else for scissors.");
                playerChoice = Console.ReadLine();

                enemyChoice = rdm.Next(0,3);

                if(enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");
                    switch (playerChoice.ToLower())
                    {
                        case "r":
                            Console.WriteLine("Its a Tie!");
                            break;
                        case "p":
                            playerPoints++;
                            Console.WriteLine("Player Won!");
                            break;
                        default:
                            enemyPoints++;
                            Console.WriteLine("Enemy Won!");
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");
                    switch (playerChoice.ToLower())
                    {
                        case "r":
                            enemyPoints++;
                            Console.WriteLine("Enemy Won!");
                            break;
                        case "p":
                            Console.WriteLine("Its a Tie!");
                            break;
                        default:
                            playerPoints++;
                            Console.WriteLine("Player Won!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissors.");
                    switch (playerChoice.ToLower())
                    {
                        case "r":
                            playerPoints++;
                            Console.WriteLine("Player Won!");
                            break;
                        case "p":
                            enemyPoints++;
                            Console.WriteLine("Enemy Won!");
                            break;
                        default:
                            Console.WriteLine("Its a Tie!");
                            break;
                    }
                }
                Console.WriteLine("Player Score: " + playerPoints + " - Enemy Score: " + enemyPoints);
            }

            if (playerPoints > enemyPoints)
                Console.WriteLine("Player won the game!");
            else
                Console.WriteLine("Enemy won the game!");

            Console.ReadKey();
        }
    }
}
