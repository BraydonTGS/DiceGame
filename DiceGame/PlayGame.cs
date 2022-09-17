using System;
using static System.Console;
namespace DiceGame
{
    public class PlayGame
    {
        private string GameName;
        private Random RandomGenerator;
        private int Score;

        private string Roll = @"    +---------+
    | ?     ? |
    | ?  ?  ? |
    | ?     ? |
    +---------+";
        private string One = @"    +---------+
    |         |
    |    o    |
    |         |
    +---------+";
        private string Two = @"    +---------+
    | o       |
    |         |
    |       o |
    +---------+";
        private string Three = @"    +---------+
    | o       |
    |    o    |
    |       o |
    +---------+";
        private string Four = @"    +---------+
    | o     o |
    |         |
    | o     o |
    +---------+";
        private string Five = @"    +---------+
    | o     o |
    |    o    |
    | o     o |
    +---------+";
        private string Six = @"    +---------+
    | o     o |
    | o     o |
    | o     o |
    +---------+";


        public PlayGame()
        {
            Score = 0;
            GameName = "Dice & More Dice";
            RandomGenerator = new Random();
        }

        public void Start()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            Title = GameName;
            WriteLine($"> {GameName}");
            WriteLine(Roll);
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
            WriteLine(Roll);
            WriteLine("Is it going to be low {1, 2, 3 } or high {4, 5, 6 }?");

            string response = ReadLine().Trim().ToLower();
            int roll = RandomGenerator.Next(1, 7);
            WriteLine();
            ForegroundColor = ConsoleColor.DarkMagenta;

            switch (roll)
            {
                case 1:
                    WriteLine(One);
                    break;
                case 2:
                    WriteLine(Two);
                    break;
                case 3:
                    WriteLine(Three);
                    break;
                case 4:
                    WriteLine(Four);
                    break;
                case 5:
                    WriteLine(Five);
                    break;
                case 6:
                    WriteLine(Six);
                    break;
                default:
                    WriteLine("Something Broke!!!! ");
                    break;
            }
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
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine($"Score: {Score}");

        }

        public void Lose()
        {
            ForegroundColor = ConsoleColor.DarkRed;

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

