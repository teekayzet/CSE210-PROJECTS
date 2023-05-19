public abstract class Goal
{
    public string name;
    public string description;
    public bool completed;
    public int points;

    public Goal(string name, string description)
    {
        this.name = name;
        this.description = description;
        completed = false;
        points = 0;
    }

    public void Complete()
    {
        completed = true;
    }

    public abstract void Display();

    public override string ToString()
    {
        return $"{name}: {description} ({(completed ? "Completed" : "Incomplete")})";
    }
}