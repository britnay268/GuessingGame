// See https://aka.ms/new-console-template for more information
try
{
    bool validInput = false;

    while (!validInput)
    {
        Console.WriteLine(@"Choose a difficulty level by number:
        1. Easy
        2. Medium
        3. Hard
        4. Cheater");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Easy();
                validInput = true;
                break;
            case 2:
                Medium();
                validInput = true;
                break;
            case 3:
                Hard();
                validInput = true;
                break;
            case 4:
                Cheater();
                validInput = true;
                break;
            default:
                Console.WriteLine("Enter a number from the available option");
                break;
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter a number");
}


void GuessingGame(int maximumTries)
{
    Console.WriteLine("Guess the secret number!");

    Random random = new Random();

    int secretNumber = random.Next(1, 100);

    int tries = 0;

    while (tries < maximumTries || maximumTries == 0)
    {
        tries++;
        Console.Write($"Your guess ({tries})> ");

        try
        {
            int input = int.Parse(Console.ReadLine());
            if (input == secretNumber)
            {
                Console.WriteLine("Success! You've guessed right!");
                break;
            }
            else
            {
                Console.WriteLine(@$"You guess is {(input > secretNumber ? "too high" : "too low")}! {(maximumTries == 0 ? "": $"You have {maximumTries - tries} guesses left!")}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number");
        }

    }

    if (tries == maximumTries)
        Console.WriteLine($"Ooops - You've run out of guesses! Secret Number was: {secretNumber}");

    Console.Read();
}

void Easy()
{
    GuessingGame(8);
}

void Medium()
{
    GuessingGame(6);
}

void Hard()
{
    GuessingGame(4);
}

void Cheater()
{
    GuessingGame(0);
}