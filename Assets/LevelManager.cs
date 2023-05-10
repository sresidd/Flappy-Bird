using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject GameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<PlayerController>().OnObstacleCollision += GameOver;
    }

    private void GameOver()
    {
        GameOverUI.SetActive(true);
    }

    public void ReloadGame(){
        SceneManager.LoadScene(0);
    }
}
