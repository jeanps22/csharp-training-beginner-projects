using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TurnBasedCombatGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enemyHp = 20, playerHp = 40;
            Random rnd = new Random();
            int points = 0;
            int enemyCommand;
            string command;
            do
            {
                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player HP - " + playerHp + ". Enemy HP - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h to heal!'");
                command = Console.ReadLine();
                points = rnd.Next(1,11);
                if (command.ToLower() == "a")
                {
                    enemyHp -= points;
                    Console.WriteLine("Player attacks enemy and deals " + points + " damage");
                }  
                else if (command.ToLower() == "h")
                {
                    playerHp += points;
                    Console.WriteLine("Player restores " + points + " health points");
                }
                    
                else
                    Console.WriteLine("Player missed!");

                Console.WriteLine("-- Enemy Turn --");
                Thread.Sleep(1000);
                points = rnd.Next(1, 11);
                enemyCommand = rnd.Next(0, 2);

                if (enemyCommand == 0)
                {
                    playerHp -= points;
                    Console.WriteLine("Enemy attacks and deals " + points + " damage");
                }
                else {
                    enemyHp += points;
                    Console.WriteLine("Enemy restores " + points + " health points");
                }
                   
            } while (enemyHp > 0 && playerHp > 0);

            if (enemyHp > 0)
                Console.WriteLine("Congratulations, You Have Won!");
            else Console.WriteLine("You Lose!");

            Console.ReadKey();
        }
    }
}
