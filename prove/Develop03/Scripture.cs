using System;
using System.Collections.Generic;

class Scripture
{
    private List<Word> Words;
    

    private Verse scriptureVerse;
    
    public Scripture (Verse _scriptureVerse, string _scriptureText)
    {
        scriptureVerse = _scriptureVerse;
        Words = new List<Word>(); // initialize the Words list
        CreateWords(_scriptureText);
    }

    private void CreateWords(string _scriptureText)
    {
        List<string> allwords = _scriptureText.Split(' ').ToList();
        foreach (string item in allwords)
        {
            Word word = new Word(item);
            Words.Add(word);
        }
    }
    public string GetScripture()
    {
        string scriptureText = "";
        foreach (Word word in Words)
        {
            if(word.GetIsHidden() == false)
            {
                scriptureText += word.GetWord() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetWord().Length) + "";
            }
        }
        return ($"{scriptureVerse.GetVerse()} {scriptureText}");
    }
    public bool HasWordsLeft()
    {
        bool retValue = false;
        foreach (Word word in Words)
        {
            if (word.GetIsHidden() == false)
            {
                retValue = true;
            }
        }
        return retValue;
    }
public void RemoveWords()
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;
        do
        {
            int rndIndex = new Random().Next(0, Words.Count());
            if (Words[rndIndex].GetIsHidden() == false)
            {
                Words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while(wordsRemoved != numWordsToRemove && HasWordsLeft() == true);
    }
}
