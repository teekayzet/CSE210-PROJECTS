using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Etnter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int num = 0;
        for(;;)
        {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        num = int.Parse(number);
        numbers.Add(num);
        if(num == 0)
        {
            break;
        }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double avg = numbers.Average();
        Console.WriteLine($"The average is: {avg}");
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}