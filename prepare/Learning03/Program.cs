using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction f1 = new Fraction("6");
        f1.SetTop("5");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());



        Fraction f2 = new Fraction("3", "4");

         Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());


        f2.SetTop("1");
        f2.SetBottom("3");

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

    }
}