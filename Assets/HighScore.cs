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
    private void Awake()
    {
        FindObjectOfType<PlayerController>().OnBlockPassed += IncrementScore;
        // currentScoreText.text = currentScore.T
        currentScoreText.text = currentScore.ToString();
        highScore = PlayerPrefs.GetInt(highScoreKey);
        highScoreText.text = highScore.ToString();
    }

}