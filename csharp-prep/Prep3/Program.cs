using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int guess = 0;
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);
        for(int i=0; i<100;)
        {
        do
        {
        Console.Write("What is your guess? ");
        string guessNum = Console.ReadLine();
        guess = int.Parse(guessNum);
        if (randomNumber > guess)
        {
            Console.WriteLine("lower");
        }
        else if (randomNumber < guess)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        count++;
        }while (randomNumber > guess || randomNumber < guess);
        Console.WriteLine($"You guessed right after {count} times");
        break;
        }
    }
}