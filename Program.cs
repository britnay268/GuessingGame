// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"Choose a difficulty level by number:
1. Easy - 8 guesses
2. Medium - 6 guesses
3. Hard - 4 guesses");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Easy();
        break;
    case 2:
        Medium();
        break;
    case 3:
        Hard();
        break;
    default:
        Console.WriteLine("Enter a valid option");
        break;
}

void Easy()
{
    Console.WriteLine("Guess the secret number!");

    Random random = new Random();

    int secretNumber = random.Next(1, 100);

    int tries = 0;

    while (tries < 8)
    {
        tries++;
        Console.Write($"Your guess ({tries})> ");

        int input = int.Parse(Console.ReadLine());

        if (input == secretNumber)
        {
            Console.WriteLine("Success! You've guessed right!");
            break;
        }
        else
        {
            Console.WriteLine(@$"You guess is {(input > secretNumber ? "too high" : "too low")}! You have {8 - tries} guesses left!");
        }
    }

    if (tries == 8)
        Console.WriteLine($"Ooops - You've run out of guesses! Secret Number was: {secretNumber}");

    Console.Read();
}

void Medium()
{
    Console.WriteLine("Guess the secret number!");

    Random random = new Random();

    int secretNumber = random.Next(1, 100);

    int tries = 0;

    while (tries < 6)
    {
        tries++;
        Console.Write($"Your guess ({tries})> ");

        int input = int.Parse(Console.ReadLine());

        if (input == secretNumber)
        {
            Console.WriteLine("Success! You've guessed right!");
            break;
        }
        else
        {
            Console.WriteLine(@$"You guess is {(input > secretNumber ? "too high" : "too low")}! You have {6 - tries} guesses left!");
        }
    }

    if (tries == 6)
        Console.WriteLine($"Ooops - You've run out of guesses! Secret Number was: {secretNumber}");

    Console.Read();
}

void Hard()
{
    Console.WriteLine("Guess the secret number!");

    Random random = new Random();

    int secretNumber = random.Next(1, 100);

    int tries = 0;

    while (tries < 4)
    {
        tries++;
        Console.Write($"Your guess ({tries})> ");

        int input = int.Parse(Console.ReadLine());

        if (input == secretNumber)
        {
            Console.WriteLine("Success! You've guessed right!");
            break;
        }
        else
        {
            Console.WriteLine(@$"You guess is {(input > secretNumber ? "too high" : "too low")}! You have {4 - tries} guesses left!");
        }
    }

    if (tries == 4)
        Console.WriteLine($"Ooops - You've run out of guesses! Secret Number was: {secretNumber}");

    Console.Read();
}