using System;

public abstract class Narrator
{
    private readonly string _introduction;
    private readonly string _conclusion;
    private int _duration;

    public Narrator(string introduction, string conclusion)
    {
        _introduction = introduction;
        _conclusion = conclusion;
    }

    public string GetIntroduction()
    {

        Console.WriteLine(_introduction);
        return _introduction;
    }

    public string GetConclusion()
    {
        Console.WriteLine($"{_conclusion}");
        return _conclusion;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration()
    {
        Console.Write("How long would you like to spend on this activity? (in seconds)");
        _duration = int.Parse(Console.ReadLine());
    }
}
