using System;

public class Reflection : Narrator
{
    public Reflection() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Thank you for participating in this activity.")
    {
        GetIntroduction();
        SetDuration();
        // Select a random prompt to show the user.
        string prompt = new[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        }
        .Random();

        // Display the prompt and give the user a countdown to start thinking about it.
        Console.WriteLine(prompt);
        Console.WriteLine("Please take a few seconds to think about this.");
        Console.WriteLine("(Press Enter to continue)");
        Console.ReadLine();

        // Prompt the user to reflect on questions that relate to this experience.
        Console.WriteLine("Please reflect on the following questions about this experience:");
        string[] questions = new[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        for (int i = 0; i < GetDuration() && i < questions.Length; i++)
        {
            Console.WriteLine("Question " + (i + 1) + ": " + questions[i]);
            Console.WriteLine("(Press Enter to continue)");
            Console.ReadLine();
        }
        GetConclusion();
    }
}