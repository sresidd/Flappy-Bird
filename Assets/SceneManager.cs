using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
