Random random = new Random();
int correctNumber = random.Next(1, 101);  // Random number between 1 and 100
int userGuess = 0;
bool isGuessedCorrectly = false;

Console.WriteLine("Guess the number (between 1 and 100):");

while (!isGuessedCorrectly)
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out userGuess))
    {
        if (userGuess < correctNumber)
        {
            Console.WriteLine("Your guess is too low!");
        }
        else if (userGuess > correctNumber)
        {
            Console.WriteLine("Your guess is too high!");
        }
        else
        {
            Console.WriteLine("Congratulations! You've guessed the right number!");
            isGuessedCorrectly = true;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}
