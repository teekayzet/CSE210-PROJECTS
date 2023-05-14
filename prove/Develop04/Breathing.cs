using System;

public class Breathing : Narrator
{
    public Breathing() : base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Thank you for participating in this activity.")
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        // Get the user's input for the duration of the activity.
        GetIntroduction();
        Console.WriteLine();
        SetDuration();
        Console.Clear();

        // Display the standard starting message.
        Console.WriteLine();

        Console.WriteLine("Get ready...");
        for (int t = 5; t > 0; t--)
        {
            Console.Write(t);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


        Console.WriteLine();
        // Start the breathing cycle.
        for (int i = 0; i < GetDuration(); i++)
        {
        
            // Display a message to breathe in.
            Console.WriteLine("Breathe in...");
            for (int t = 5; t > 0; t--)
            {
                Console.Write(t);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            // Display a message to breathe out.
            Console.WriteLine("Now Breathe out...");
            for (int t = 5; t > 0; t--)
            {
            Console.Write(t);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    
            }
        }
            Console.WriteLine();
            Console.WriteLine("Well done!");
            for (int t = 5; t > 0; t--)
            {
                Console.Write(t);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        GetConclusion();
    }
}
