using UnityEngine;

public class WordInput : MonoBehaviour {

    public WordManager wordManager;

    private void Update()
    {
        foreach (char letter in Input.inputString)
        {
            //Debug.Log(letter);
            wordManager.TypeLetter(letter);
        }
    }
}
