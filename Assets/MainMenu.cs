using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public void StartButton()
    {
        Time.timeScale = 1;
        mainMenuCanvas.SetActive(false);
    }


}
