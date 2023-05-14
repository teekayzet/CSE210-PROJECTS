using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");

        // Define the menu options
        string[] menuOptions = {
            "Start breathing activity",
            "Start reflecting activity",
            "Start listing activity",
            "Quit"
        };

        // Display the menu options
        for (int i = 0; i < menuOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }

        // Prompt the user for input
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        // Validate the user's choice
        if (choice < 1 || choice > menuOptions.Length)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }

        // Start the selected activity
        switch (choice)
        {
            case 1:
                Console.Clear();
                Breathing breathing = new Breathing();
                break;
            case 2:
                Console.Clear();
                Reflection reflection = new Reflection();
                break;
            case 3:
                Console.Clear();
                Listing listing = new Listing();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Quitting...");

                return;
        }
    }
}
