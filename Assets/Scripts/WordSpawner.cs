using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord() 
    {
        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);

        //Brackeys code... doesn't work?!
        //GameObject wordObject = (GameObject)Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);

        //My solution to code above that doesn't work.
        GameObject wordObj = (GameObject)Instantiate(wordPrefab, wordCanvas);
        wordObj.transform.position = randomPosition;
        wordObj.transform.rotation = Quaternion.identity;
        WordDisplay wordDisp = wordObj.GetComponent<WordDisplay>();
        //Debug.Log(wordObject.transform.position);

        return wordDisp;
    }
}
