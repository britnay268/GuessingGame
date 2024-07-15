// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the secret number!");

int input = int.Parse(Console.ReadLine());

int secretNumber = 42;

if (input == secretNumber)
{
    Console.WriteLine("Success! You've guessed right!"); 
}
else
{
    Console.WriteLine("Fail - Wrong guess!");
}

Console.Read();