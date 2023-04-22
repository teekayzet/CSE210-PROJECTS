using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string letter = "";
        if (percent > 90 || percent == 90)
        {
            letter = "A";
        }
        else if(percent > 80 || percent == 80)
        {
            letter = "B";
        }
        else if(percent > 70 || percent == 70)
        {
            letter = "C";
        }
        else if(percent > 60 || percent == 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int lastDigit = int.Parse(percent.ToString().Substring(percent.ToString().Length - 1));
        string sign = "";
        if(lastDigit>=7)
        {
            sign = "+";
        }
        else if(lastDigit<3)
        {
            sign = "-";
        }
        if (percent <= 89 && percent >= 60)
        {
            string finalGrade = letter + sign;
            Console.WriteLine($" your grade is {finalGrade} ");
        }
        else
        {
            Console.WriteLine($" your grade is {letter}");
        }
        if (percent > 70 || percent == 70)
        {
            Console.WriteLine("Congratulate you passed your exams!!!");
        }
        else
        {
            Console.WriteLine("You can do better next time!");
        }
    }
}