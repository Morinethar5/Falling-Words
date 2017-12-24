using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

    public string word;
    private int typeIndex;

    private WordDisplay display;

    [SerializeField]
    private int score = 0;

    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        display = _display;
        display.SetWord(word);
        typeIndex = 0;
        SetScore();
    }

    public void SetScore() 
    {
        if (word.Length <= 4)
        {
            score = 10;
        } 
        if (word.Length >= 4 && word.Length <= 6)
        {
            score = 25;
        } 
        if (word.Length >= 7)
        {
            score = 50;
        }
    }

    public int GetScore() 
    {
        return score;
    }

    public char GetNextLetter() 
    {
        return word[typeIndex];
    }

    public void TypeLetter() 
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool WordTyped() 
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            display.RemoveWord();
        }
        return wordTyped;
    }
}
