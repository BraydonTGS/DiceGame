using System;
using static System.Console;
namespace DiceGame
{
    public class PlayGame
    {
        private string GameName;
        private Random RandomGenerator;
        private int Score;


        public PlayGame()
        {
            Score = 0;
            GameName = "Dice & More Dice";
            RandomGenerator = new Random();
        }

        public void Start()
        {
            Title = GameName;
            WriteLine($"> {GameName}");
            WriteLine("\n> Let's Begin!!!");
            WriteLine("\n> Instructions: ");
            WriteLine("\t> I will roll a die. ");
            WriteLine("\t> You will guess if it is high or low. ");
            WriteLine("\t> If correct, You get a point. ");
            WriteLine("\n> Ready to Play? (Y/N) ");
            string response = ReadLine().Trim().ToLower();
            if (response == "y")
            {
                WriteLine("Awesome! Let's Begin... ");
                PlayRound();
            }
            else
            {
                WriteLine("Okay.... Next Time");
            }
            Write("Press Any Key to Exit: ");
            ReadLine();
        }

        private void PlayRound()
        {
            Clear();

            WriteLine("I'm about to roll the dice! ");
            WriteLine("Is it going to be low {1, 2, 3 } or high {4, 5, 6 }?");

            string response = ReadLine().Trim().ToLower();
            int roll = RandomGenerator.Next(1, 7);
            WriteLine($"The roll was {roll}");
            if (response == "high")
            {
                WriteLine("You Guessed High... ");
                if (roll <= 3)
                {
                    Lose();
                }
                else
                {
                    Win();
                }
            }
            else if (response == "low")
            {
                WriteLine("You Guessed Low... ");
                if (roll <= 3)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }
            else
            {
                WriteLine("Invalid Guess... ");
            }

            PlayAgain();

        }

        private void Win()
        {
            Score++;
            WriteLine("You Win! ");
            WriteLine($"Score: {Score}");

        }

        public void Lose()
        {
            Score--;
            WriteLine("You lose!!! ");
            WriteLine($"Score: {Score}");

        }

        public void PlayAgain()
        {
            Write("Would you like to play again? (Y/N) ");
            string response = ReadLine().ToLower().Trim();

            if (response == "y")
            {
                PlayRound();
            }
            else
            {
                Write("Sounds good! See you next time. ");
            }
        }
    }
}

