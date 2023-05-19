public class EternalGoal : Goal
{
    public EternalGoal(string name, string description) : base(name, description)
    {
        points = 10;
    }
    public override void Display()
    {
        Console.WriteLine($"[Simple Goal] {name}: {description} ({(completed ? "Completed" : "Incomplete")})");
    }

}