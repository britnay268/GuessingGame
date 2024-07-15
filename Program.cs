// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the secret number!");

int secretNumber = 42;

int tries = 0;

while (tries < 4)
{
    int input = int.Parse(Console.ReadLine());
    if (input == secretNumber)
    {
        Console.WriteLine("Success! You've guessed right!");
        break;
    }
    else
    {
        Console.WriteLine("Fail - Wrong guess! Try Again!");
        tries++;
    }
}

if (tries == 4)
    Console.WriteLine("Ooops - You've run out of guesses!");

Console.Read();