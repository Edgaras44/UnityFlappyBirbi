using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highscoreText;

    
    void Update()
    {
        highscoreText.text = "HIGHSCORE: \n" + PlayerPrefs.GetInt("highscore");
    }
}
