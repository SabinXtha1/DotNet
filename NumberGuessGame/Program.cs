bool playAgain = true;
while (playAgain)
{
    int maxNumber = 100;
    int minNumber = 1;
    Random random = new Random();
    int randomNumber = random.Next(minNumber, maxNumber + 1);
    int userGuess = 0;
    Console.WriteLine("Welcome to the Number Guessing Game!");
    Console.WriteLine($"Guess a number between {minNumber} and {maxNumber}.");
    int userInput = 0;
    while (userInput != randomNumber)

    {
        Console.Write("Enter your guess:");
        userInput =Convert.ToInt32(Console.ReadLine());
        if (userInput > randomNumber)
        {
            Console.WriteLine("Too high! Try again.");
        }
        else if (userInput < randomNumber)

        {
            Console.WriteLine("Too low! Try again.");
        }
        userGuess++;

    }
    Console.WriteLine($"\tCongratulations!🎊🎉 \n You've guessed the number {randomNumber} in {userGuess} attempts.");
    Console.WriteLine("Do you want to play again? (yes/no)");
    string playAgainInput = Console.ReadLine().ToLower();
    if (playAgainInput != "yes")
    {
        playAgain = false;
        Console.WriteLine("Thank you for playing! Goodbye!👋");
    }
    else
    {

        Console.Clear();
    }

}