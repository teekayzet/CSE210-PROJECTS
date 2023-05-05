using System;

class Verse
{
    private string book, chapter, verseStart, verseEnd;

    public Verse(string _book, string _chapter, string _singleVerse)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _singleVerse;
        verseEnd = "";
    }

    public Verse(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = _verseEnd;
    }

    public string GetVerse()
    {
        if (verseEnd == "")
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}