using System;
using static System.Console;
namespace DiceGame
{
    public class PlayGame
    {
        private string GameName = "Dice & More Dice";
        private int Score;


        public PlayGame()
        {
            Score = 0;
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
            Write("Press Any Key to Exit. ");
            ReadKey();
        }

        private void PlayRound()
        {
            Clear();
            WriteLine("I'm about to roll the dice! ");
            WriteLine("Is it going to be low {1 , 2, 3 } or high {4, 5, 6 }?");
            string response
        }

        private void Win()
        {

        }

        public void Lose()
        {

        }

        public void PlayAgain()
        {

        }
    }
}

