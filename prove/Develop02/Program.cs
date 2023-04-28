using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuUserinput = 0;

        List<string> menu = new List<string>
        {
            "Please Select One Of The Following Choices:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do? "
        };

        while (menuUserinput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuUserinput = int.Parse(Console.ReadLine());

            switch (menuUserinput)
            {
                case 1:
                    PromptGenerator promptGenerator = new PromptGenerator();
                    Console.WriteLine(promptGenerator.GetRandomPrompt());
                    Console.WriteLine("Enter response: ");
                    string response = Console.ReadLine();
                    DateTime date = DateTime.Now;
                    Entry entry = new Entry(date, promptGenerator.GetRandomPrompt(), response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Enter file name: ");
                    string fileName = Console.ReadLine();
                    journal.LoadJournalFromFile(fileName);
                    break;
                case 4:
                    Console.WriteLine("Enter file name: ");
                    fileName = Console.ReadLine();
                    journal.SaveJournalToFile(fileName);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }
}

