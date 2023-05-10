using System;

class Program
{
    static void Main(string[] args)
    {
    
        Assignment a1 = new Assignment("Tkudzwa", "Indices");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Mutamburigwa", "Binomials", "4.9", "10-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Shamilla Msipha", "Modern Warfare", "The Challeges we face");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}