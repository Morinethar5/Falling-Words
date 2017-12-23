using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord() 
    {
        Vector3 randomP = new Vector3(Random.Range(-280f, 280f), 7f);

        GameObject wordObject = Instantiate(wordPrefab, randomP, Quaternion.identity, wordCanvas);
        WordDisplay wordDisp = wordObject.GetComponent<WordDisplay>();

        return wordDisp;
    }
}
