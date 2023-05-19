public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description) : base(name, description)
    {
        points = 2;
    }
    public override void Display()
    {
        Console.WriteLine($"[Simple Goal] {name}: {description} ({(completed ? "Completed" : "Incomplete")})");
    }

}
