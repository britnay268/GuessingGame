// See https://aka.ms/new-console-template for more information
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
        Console.WriteLine($"Fail - Wrong guess! You have {4 - tries} guesses left!");
    }
}

if (tries == 4)
    Console.WriteLine($"Ooops - You've run out of guesses! Secret Number was: {secretNumber}");

Console.Read();