using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseScreen, PauseButton, InfoButton, infoScreen;

    public void pause()
    {
        pauseScreen.SetActive (true);
        PauseButton.SetActive(false);
        infoScreen.SetActive(false);
        Time.timeScale = 0;
    }

    public void resume()
    {
        pauseScreen.SetActive(false);
        PauseButton.SetActive(true);
        infoScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void info()
    {
        pauseScreen.SetActive(false);
        infoScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Back()
    {
        pauseScreen.SetActive(true);
        PauseButton.SetActive(false);
        infoScreen.SetActive(false);
        Time.timeScale = 0;
    }

}
