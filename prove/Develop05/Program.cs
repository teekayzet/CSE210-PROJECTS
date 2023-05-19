while (true)
{
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. Record Event");
    Console.WriteLine("3. Show Goals");
    Console.WriteLine("4. Show Score");
    Console.WriteLine("5. Delete Goal");
    Console.WriteLine("6. Quit");

    // Prompt the user for input
    Console.Write("Select a choice from the menu: ");
    int choice = int.Parse(Console.ReadLine());

    // Validate the user's choice
    if (choice < 1 || choice > 8)
    {
        Console.WriteLine("Invalid choice. Please try again.");
        continue;
    }

    List<Goal> goals = new List<Goal>();
    // Start the selected activity
    switch (choice)
    {
        case 1:
            // Create a new goal
            Console.Write("Enter the name of the goal: ");
            string name = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            string description = Console.ReadLine();
            Console.Write("Enter the type of the goal (1 for Eternal, 2 for Simple, 3 for Checklist): ");
            int type = int.Parse(Console.ReadLine());
            Goal goal;
            switch (type)
            {
                case 1:
                    goal = new EternalGoal(name, description);
                    break;
                case 2:
                    goal = new SimpleGoal(name, description);
                    break;
                case 3:
                    goal = new ChecklistGoal(name, description);
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    continue;
            }
            if (goal != null)
            {
                goals.Add(goal);
                SaveGoals(goals);
            }   

            break;
        case 2:
            // Record an event
            CompleteGoal(goals);
            break;
        case 3:
            // Show the list of goals
            foreach (Goal g in goals)
            {
                Console.WriteLine(g);
            }
            break;
        case 4:
            // Show the user's score
            int score = 0;
            foreach (Goal g in goals)
            {
                if (g.completed)
                {
                    score += g.points;
                }
            }
            Console.WriteLine($"Your score is {score}.");
            break;
        case 5:
            // Delete a goal
            DeleteGoal(goals);
            break;
        case 6:
            // Quit
            return;
    }
}
static void DeleteGoal(List<Goal> goals)
{
    Console.Write("Enter the name of the goal to delete: ");
    string name = Console.ReadLine();

    Goal goal = goals.FirstOrDefault(g => g.name == name);

    if (goal == null)
    {
        Console.WriteLine("Goal not found. Please try again.");
        return;
    }

    goals.Remove(goal);
    Console.WriteLine($"Goal '{goal.name}' has been deleted.");
}

static void CompleteGoal(List<Goal> goals)
{
    Console.Write("Enter the name of the goal you completed: ");
    string name = Console.ReadLine();

    Goal goal = goals.FirstOrDefault(g => g.name == name);

    if (goal == null)
    {
        Console.WriteLine("Goal not found. Please try again.");
        return;
    }

    if (goal.completed)
    {
        Console.WriteLine("Goal already completed.");
        return;
    }

    goal.completed = true;
    Console.WriteLine($"Congratulations! You completed the goal '{goal.name}' and earned {goal.points} points.");

    // Award points for completing the goal
    // You can adjust the number of points awarded based on the goal type or other criteria
    int pointsEarned = 10;
    goal.points += pointsEarned;
}

static void SaveGoals(List<Goal> goals)
{
    using (StreamWriter writer = new StreamWriter("goals.csv"))
    {
        foreach (Goal goal in goals)
        {
            writer.WriteLine($"{goal.name},{goal.description},{goal.completed},{goal.points}");
        }
    }
    Console.WriteLine("Goals saved successfully!");
}
