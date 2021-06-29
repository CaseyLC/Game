ing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int points = 0;
            int coins = 0;
            int life = 3;
            int pointsForNextLife = 10000;
            string interaction = "block, block, block, goomba, ";
            string[] words = interaction.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine($"<{word}");
                Console.WriteLine(score);
                if (score == pointsForNextLife)
                {
                    life += 1;
                    points -= 10000;
                    Console.WriteLine("You have Gained a Life!");

                }
                if (life == 0)
                {
                    Console.WriteLine("You Have Died");
                }
                else if (word == "Block")
                {
                    
                    coins += 1;
                    points += 10;
                    score += 10;
                }
                else if (word == "InvincibleBirdHunter,")
                {
                    life -= 1;
                }
                else if (word == "EveningGrosbeak,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "VulnerableBirdHunter,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "GreaterPrairieChicken,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "IcelandGull,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "Orange-belliedParrot,")
                {
                    score += 5000;
                    points += 5000;

                }
                else if (word == "CrestedIbis,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "RedCrossbill,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "GreatKiskudee,")
                {
                    score += 100;
                    points += 100;
                }
                else if (word == "Red-necked Phalarope,")
                {
                    score += 100;
                    points += 100;
                }
            }
            Console.WriteLine($"Total Points: +{score} " +
                $"Lives Remaining: {life}");

            Console.ReadKey();
        }
    }
}