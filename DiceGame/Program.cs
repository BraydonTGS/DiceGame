using System;
using static System.Console;

Random myRandomGenerator = new Random();

int randNum = myRandomGenerator.Next(1, 7);
WriteLine(randNum);
ReadKey();