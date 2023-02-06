using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    TMP_Text scoreTxt;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<PlayerController>().OnBlockPassed += IncrementScore;
        scoreTxt = GetComponent<TMP_Text>();
        scoreTxt.text = score.ToString();
    }

    private void IncrementScore()
    {
        score++;
        scoreTxt.text = score.ToString();
    }
}
