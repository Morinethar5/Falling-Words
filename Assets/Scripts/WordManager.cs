using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour {

    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    public Text scoreText;
    [SerializeField]
    private int score = 0;

    public Text speedText;
    [SerializeField]
    private int speed = 0;

    public int lives = 3;
    public Image heartPrefab;
    public Transform heartCanvas;

    public Collider floor;

    public Image heart1;
    public Image heart2;
    public Image heart3;

    public GameObject gameOverUI;
    public Text gameOverScoreText;

    public GameObject pausedUI;

    private void Start()
    {
        scoreText.text = score.ToString();

        heart1 = Instantiate(heartPrefab, heartCanvas);
        heart2 = Instantiate(heartPrefab, heartCanvas);
        heart3 = Instantiate(heartPrefab, heartCanvas);

        gameOverUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void AddWord() 
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        //Debug.Log(word.word);

        speed += 1*Mathf.RoundToInt(GetComponent<WordTimer>().wordDelay);
        speedText.text = speed.ToString();

        words.Add(word);
    }

    public void TypeLetter(char letter) 
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        } else 
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped()) 
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            score += activeWord.GetScore();
            scoreText.text = score.ToString();
        }
    }

    public void ClearActiveWord()
    {
        hasActiveWord = false;
        words.Remove(activeWord);
    }

    public void GameOver() 
    {
        //Debug.Log("GAME OVER!");
        gameOverScoreText.text = score.ToString();
        gameOverUI.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("_Main");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

    public void PauseGame() 
    {
        PauseToggle();
    }

    private void PauseToggle()
    {
        pausedUI.SetActive(!pausedUI.activeSelf);

        if (pausedUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
