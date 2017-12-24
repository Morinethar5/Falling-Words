using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = { "sidewalk", "table", "three", "periodic", "somber", "majestic", "inexpensive", "number", "private", "provide", 
                                        "dashing", "stare", "grin", "pretend", "terrible", "versed", "force", "jagged", "endurable", "yoke", "pie", 
                                        "nervous", "drab", "dapper", "sip", "warm", "terrific", "dogs", "prevent", "precede", "lucky", "load", "rescue", 
                                        "flood", "identify", "acceptable", "market", "position", "act", "point", "depend", "hat", "punishment", "crib", 
                                        "normal", "right", "thing", "time", "legs", "war", "luxuriant", "zebra", "tickle", "fireman", "special", 
                                        "current", "wicked", "pastoral", "labored", "white", "squalid", "wash", "smart", "land", "effect", "guide", "turn",
                                        "vein", "valuable", "giants", "pricey", "agreeable", "hose", "guarantee", "march", "interfere", "narrow", 
                                        "deeply", "puzzling", "mind", "water", "north", "fumbling", "bag", "decorate", "gruesome", "stove", "digestion", 
                                        "practise", "abortive", "explain", "giant", "leg", "spell", "handsome", "wire", "wish", "low", "flow", 
                                        "righteous", "skip", "foamy", "rabid", "care", "thoughtful", "copy" };

    public static string GetRandomWord() 
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
