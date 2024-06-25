using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            Random randomNumber = new Random();
            int playerScore = 0;
            int enemyScore = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();

                playerRandomNum = randomNumber.Next(1,7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = randomNumber.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    Console.WriteLine("Player wins this round!");
                    playerScore++;
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    Console.WriteLine("Enemy wins this round!");
                    enemyScore++;
                }
                else
                {
                    Console.WriteLine("Its a Draw!");
                }

                Console.WriteLine("The score is now - Player : " + playerScore + ". Enemy : " + enemyScore +".");
                Console.WriteLine();
            }

            if (playerScore > enemyScore)
                Console.WriteLine("You won!");
            else if (playerScore < enemyScore)
                Console.WriteLine("You lose.");
            else
                Console.WriteLine("Its a Draw!");

            Console.ReadKey();
        }
    }
}
