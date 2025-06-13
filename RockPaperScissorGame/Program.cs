bool gameStart = true;
while (gameStart)
{
    string userInput;
    int computerInput;
    string computerChoice = "";
    int randomNumber = (new Random()).Next(1, 4);
    computerInput = randomNumber;
    Console.WriteLine("Welcome to Rock, Paper, Scissors!");
    Console.WriteLine("Please enter your choice:");
    userInput = Console.ReadLine().ToUpper();
    switch (computerInput)
    {
        case 1:
            computerChoice = "ROCK";
            break;
        case 2:
            computerChoice = "PAPER";
            break;
        case 3:
            computerChoice = "SCISSORS";J
            break;
    }
    switch (userInput)
    {
        case "ROCK":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine("It's a tie! You both chose ROCK.");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine("You lose! PAPER covers ROCK.");
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine("🎉Congratulation !🎊 You Win, ROCK crushes SCISSORS.");
            }

            break;
        case "PAPER":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine(" 🎉Congratulation !🎊 You Win, PAPER covers ROCK.");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine("It's a tie! You both chose PAPER.");
            }
            else if (computerChoice == "SCISSORS")
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
            Console.WriteLine("You Lose!  SCISSORS Cut Paper.");
            {
            }
            break;
        case "SCISSORS":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine("You Lose! ROCK crushes SCISSORS.");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
                Console.WriteLine("🎉Congratulation !🎊 You Win, SCISSORS Cut PAPER.");
            }
            else if (computerChoice == "SCISSORS")
                Console.WriteLine($"💻Computer chose: {computerChoice}\n 😎You chose:{userInput}");
            Console.WriteLine("It's a tie! You both chose SCISSORS.");
            {
            }
            break;
    }
    Console.WriteLine("Do you want to play again? (yes/no)");
    string response = Console.ReadLine();
    if (response == null || response.ToLower() != "yes")
    {
        Console.WriteLine("Thank You for playing!Bye for now!👋");
        gameStart = false;
    }
    else
    {
        Console.Clear();
        }
     

}