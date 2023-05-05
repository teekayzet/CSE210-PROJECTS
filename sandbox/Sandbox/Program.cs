using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Verse scriptureVerse = new Verse("Genesis", "2", "21", "24");
        Scripture scripture = new Scripture(scriptureVerse, "And the Lord God caused a deep sleep to fall upon Adam, and he slept: and he took one of his ribs, and closed up the flesh instead thereof; And the rib, which the Lord God had taken from man, made he a woman, and brought her unto the man.And Adam said, This is now bone of my bones, and flesh of my flesh: she shall be called bWoman, because she was taken out of Man.Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.");
        
        string userInput = "";
        
        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.ReadLine();
            Console.WriteLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Great You did it, hope you mastered it!!!");
    }
}

class Verse
{
    private string book;
    private string chapter;
    private string startVerse;
    private string endVerse;
    
    public Verse(string _book, string _chapter, string _startVerse, string _endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _startVerse;
        endVerse = _endVerse;
    }
    
    public string GetReference()
    {
        return book + " " + chapter + ":" + startVerse + "-" + endVerse;
    }
}

class Word
{
    private string word;
    private bool isHidden;
    
    public Word(string _word)
    {
        word = _word;
        isHidden = false;
    }
    
    public bool GetIsHidden()
    {
        return isHidden;
    }
    
    public void SetIsHidden(bool _isHidden)
    {
        isHidden = _isHidden;
    }
    
    public string GetWord()
    {
        return word;
    }
}

class Scripture
{
    private List<Word> Words;
    private Verse scriptureVerse;
    
    public Scripture (Verse _scriptureVerse, string _scriptureText)
    {
        scriptureVerse = _scriptureVerse;
        CreateWords(_scriptureText);
    }
    
    private void CreateWords(string _scriptureText)
    {
        Words = new List<Word>();
        string[] words = _scriptureText.Split(' ');
        foreach (string word in words)
        {
            Words.Add(new Word(word));
        }
    }
    
    public string GetScripture()
    {
        string scripture = "";
        foreach (Word word in Words)
        {
            if (word.GetIsHidden())
            {
                scripture += "____ ";
            }
            else
            {
                scripture += word.GetWord() + " ";
            }
        }
        return scripture;
    }
    
    public bool HasWordsLeft()
    {
        foreach (Word word in Words)
        {
            if (word.GetIsHidden())
            {
                return true;
            }
        }
        return false;
    }
    
    public void RemoveWords()
    {
        foreach (Word word in Words)
        {
            if (word.GetIsHidden())
            {
                word.SetIsHidden(false);
                break;
            }
        }
    }
} 