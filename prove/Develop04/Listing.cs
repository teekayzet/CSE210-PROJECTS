using System;
using System.Linq;

public static class ArrayExtension
{
    private static Random random = new Random();
    public static T Random<T>(this T[] array)
    {
        return array[random.Next(array.Length)];
    }
}


public class Listing : Narrator
{
    public Listing() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Thank you for participating in this activity.")
    {
        GetIntroduction();
        SetDuration();
        Console.WriteLine();
      
        string prompt = new[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        }
        .Random();

        Console.WriteLine(prompt);
        Console.WriteLine("Please take a few seconds to think about this.");
        Console.WriteLine("(Press Enter to continue)");
        Console.ReadLine();

      
        Console.WriteLine("Please list as many things as you can in this area.");
        string[] items = new string[GetDuration()];
        for (int i = 0; i < GetDuration(); i++)
        {
            Console.WriteLine("Item " + (i + 1) + ": ");
            items[i] = Console.ReadLine();
        }

        Console.WriteLine("You entered " + items.Count(x => x != null) + " items.");

        GetConclusion();
    }
}