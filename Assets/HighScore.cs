using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text highScoreText;
    public TMP_Text currentScoreText;

     int highScore;
     int currentScore = 0;

    string highScoreKey = "HighScore";

    private void IncrementScore()
    {
        currentScore++;
        currentScoreText.text = currentScore.ToString();
        if (currentScore > highScore)
        {
            highScore = currentScore;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<PlayerController>().OnBlockPassed += IncrementScore;
        // currentScoreText.text = currentScore.ToString();
        currentScoreText.text = "Journalax";
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = highScore.ToString();
    }

}