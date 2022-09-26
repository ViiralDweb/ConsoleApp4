namespace guessingNumbers;

internal class GuessTheNumber
{
    public void NumberTheGuess()
    {
        Random rnd = new Random();
        int uplimit = 0;
        int downlimit = 0;
        int numbertoguess = 0;
        int versuch = 1;
        int eingabe = 10;
        bool init = false;
        List<int> numbers = new List<int>();  //list enumerator erstellen

        //array wird erschaffen durch user eingaben
        do
        {
            Console.WriteLine("Alright, please give the upper limit first of your array");
            uplimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now give the lower limit to declare your array succesfully");
            downlimit = Convert.ToInt32(Console.ReadLine());
            if (downlimit >= uplimit)
            {
                Console.WriteLine("We've catched an error, please try again");
            }
            else
            {
                numbertoguess = rnd.Next(downlimit, uplimit);
                init = true;
            }
        } while (!init);
        Console.WriteLine($"I now have picked a number between {downlimit} and {uplimit}, go on and guess it");

        do //zufällige zahl innerhalb des arrays wird hier erraten vom user; bei fehleingaben kommt eine error message auf den user zu
        {

            Console.WriteLine($"Your {versuch}. try: ");

            bool successfullParse = Int32.TryParse(Console.ReadLine(), out eingabe);

            if (!successfullParse)
            {
                Console.WriteLine("The value you have entered is not a digit, please try again");
            }
            else
            {
                if (eingabe < downlimit || eingabe > uplimit)
                {
                    Console.WriteLine($"Your number is out of array bound, please keep it between {downlimit} to {uplimit}!");
                }
                else
                {
                    if (numbers.Contains(eingabe))
                    {
                        Console.WriteLine("You already guessed this number, please try again");
                    }


                    else if (numbertoguess < eingabe)
                    {
                        numbers.Add(eingabe);
                        Console.WriteLine("The number you're searching for is smaller");
                        versuch++;
                    }
                    if (numbertoguess > eingabe)
                    {
                        numbers.Add(eingabe);
                        Console.WriteLine("The number you're searching for is bigger");
                        versuch++;
                    }
                }

            }//process of guessing the number that has been chosen randomly within the array
             //array erstellen wo die zahlen die man erraten hat am ende anzeigen
             //noch dazu den array während prozess checken, ob die zahl schon mal erraten wurde oder nicht
        } while (eingabe != numbertoguess);
        Console.WriteLine($"Congratulations! You guessed my number ({eingabe})!");
        Console.WriteLine($"Those were the numbers you tried to guess with:");
        foreach (int guessednumbers in numbers)
        {
            Console.Write($"{guessednumbers}. ");
        }

    }
}
