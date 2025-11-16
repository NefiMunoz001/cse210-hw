using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();
        string[] splitWords = text.Split(" ");

        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hidden = 0;

        List<int> indexes = new List<int>();

        // collect indexes of words still visible
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                indexes.Add(i);
            }
        }

        // stop if no more visible words
        if (indexes.Count == 0)
            return;

        // hide up to "count" words
        while (hidden < count && indexes.Count > 0)
        {
            int randomPosition = random.Next(indexes.Count);
            int wordIndex = indexes[randomPosition];

            _words[wordIndex].Hide();
            indexes.RemoveAt(randomPosition);

            hidden++;
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (var word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }
}
