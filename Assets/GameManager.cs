using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 0;
        
    }

    
    public void GameOver()
    {
        if(Score.score > PlayerPrefs.GetInt("highscore"))
        PlayerPrefs.SetInt("highscore", Score.score);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
