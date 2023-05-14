using System;

class BreathingActivity
{
    static void Main()
    {
        Console.Write("Enter the duration of the breathing activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Breathing in...");
        for (int i = 0; i < duration / 2; i++)
        {
            Console.WriteLine("Inhale {0}/{1}", i + 1, duration / 2);
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("Breathing out...");
        for (int i = 0; i < duration / 2; i++)
        {
            Console.WriteLine("Exhale {0}/{1}", i + 1, duration / 2);
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("Breathing activity completed.");
    }
}