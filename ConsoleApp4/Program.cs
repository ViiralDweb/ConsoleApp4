using guessingNumbers;
using System;

//Console.WriteLine("Do you want to play a game? (N - No) (Y - Yes)");

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Do you want to play a game? (N - No) (Y - Yes)");
            string i = Console.ReadLine().ToUpper();

            if (i == "N")
            {
                break;
            }
            else if (i == "Y")
            {
                GuessTheNumber GTN = new GuessTheNumber();
                GTN.NumberTheGuess();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}