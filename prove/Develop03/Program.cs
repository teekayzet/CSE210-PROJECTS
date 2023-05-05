using System;

class Program
{
    static void Main(string[] args)
    {
        Verse verse = new Verse("Genesis", "2", "21", "24");
        Scripture scripture = new Scripture(verse, "And the Lord God caused a deep sleep to fall upon Adam, and he slept: and he took one of his ribs, and closed up the flesh instead thereof; And the rib, which the Lord God had taken from man, made he a woman, and brought her unto the man.And Adam said, This is now bone of my bones, and flesh of my flesh: she shall be called bWoman, because she was taken out of Man.Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            //Display Scripture
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press emter to continue or 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
        Console.WriteLine("Great You did it, hope you mastered it!!!");
    }
}