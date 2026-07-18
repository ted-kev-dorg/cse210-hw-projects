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

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // === EXCEEDS REQUIREMENTS FEATURE ===
    // This method picks a random word that is currently hidden and reveals it
    public void RevealRandomWord()
    {
        // First, let's make sure there is actually something hidden to reveal
        bool hasHiddenWords = false;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hasHiddenWords = true;
                break;
            }
        }

        // If there are hidden words, find one at random and reveal it
        if (hasHiddenWords)
        {
            Random random = new Random();
            while (true)
            {
                int randomIndex = random.Next(_words.Count);
                if (_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Show(); // Use the Show() behavior!
                    break; // Exit the loop once one word is revealed
                }
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();
        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        string joinedWords = string.Join(" ", displayedWords);
        return $"{_reference.GetDisplayText()} {joinedWords}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}