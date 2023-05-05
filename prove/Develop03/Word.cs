using System;

class Word
{
    private string word;
    private bool isHidden;
    public Word(string _word)
    {
        word = _word;
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