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
            Write("> Press Any Key to Exit: ");
            ReadKey();
        }

        private void PlayRound()
        {

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

