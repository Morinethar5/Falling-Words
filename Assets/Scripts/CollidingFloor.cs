using UnityEngine;

public class CollidingFloor : MonoBehaviour {

    public WordManager wordManager;

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Collider triggered" + col.name);

        if (col.gameObject.tag == "Word")
        {
            wordManager.lives -= 1;
            wordManager.ClearActiveWord();
            if (wordManager.lives == 2)
            {
                Destroy(wordManager.heart1);
            }
            if (wordManager.lives == 1)
            {
                Destroy(wordManager.heart2);
            }
            if (wordManager.lives == 0)
            {
                Destroy(wordManager.heart3);
                wordManager.GameOver();
            }
        }
    }
}
