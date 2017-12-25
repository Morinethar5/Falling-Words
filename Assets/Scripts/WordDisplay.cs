using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    public Text text;
    public float fallSpeed = 1f;

    public GameObject typeEffect;

    public void SetWord(string word) 
    {
        text.text = word;
    }

    public void RemoveLetter() 
    {
        text.text = text.text.Remove(0,1);
        text.color = Color.red;
        GameObject type = (GameObject)Instantiate(typeEffect, text.transform.position, Quaternion.identity);
        Destroy(type, 2f); 
    }

    public void RemoveWord() 
    {
        Destroy(gameObject);
    }

    void Update() 
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }
}
