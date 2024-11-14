using System;

class Program
{
    static void Main()
    {
        // 1. If-sats som skriver ut "Hello, World!" om 6 är större än eller lika med 3
        if (6 >= 3)
        {
            Console.WriteLine("Hello, World!");
        }

        // 2. Kod som hämtar användarnamn
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        // 3. Kod som också frågar efter lösenord
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == "kalleanka" && password == "12345") //skriver ut "Welcome!" om användarnamnet och lössen ordet är "kalleanka, 12345"
        {
            Console.WriteLine("Welcome!");
            // Skriver ut "Hello, World!" efter korrekt inloggning
            Console.WriteLine("Hello, World!");
        }
        else
        {
            // Om något av användarnamnet eller lösenordet är fel skriver den ut
            Console.WriteLine("Wrong username or password");
        }

        // 4. Loop som skriver ut "Hello, World!" 32 gånger
        for (int i = 0; i < 32; i++)
        {
            Console.WriteLine("Hello, World!");
        }

        // 5. Loop som fortsätter tills rätt lösenord skrivs
        string correctPassword = "12345";
        string userInput;

        do
        {
            Console.Write("Enter password: ");
            userInput = Console.ReadLine();
        } while (userInput != correctPassword);

        Console.WriteLine("Password correct!");

        // 6. Loop som körs 5 gånger och kollar om talet är högre än 5
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 5)
            {
                Console.WriteLine("Högre än 5!");
            }
        }

        // 7. Loop som körs tills användaren skriver in ett giltigt tal
        int userNumber;

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userNumber))
            {
                break; // Exit the loop if input is a valid integer
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        // 8. Gissa siffran-spel
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
                    Console.ReadLine();
                    isGuessedCorrectly = true;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
