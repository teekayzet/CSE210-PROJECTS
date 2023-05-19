public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description) : base(name, description)
    {
        points = 5;
    }

    public override void Display()
    {
        Console.WriteLine($"[Simple Goal] {name}: {description} ({(completed ? "Completed" : "Incomplete")})");
    }
}
