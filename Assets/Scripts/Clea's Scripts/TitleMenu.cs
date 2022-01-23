using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public GameObject TitleScreen, InfoScreen, BackButton, PlayButton, MoveListButton;
    public GameObject SettingsButton, SettingsScreen;

    public void info()
    {
        TitleScreen.SetActive(false);
        SettingsScreen.SetActive(false);
        InfoScreen.SetActive(true);
        BackButton.SetActive(true);
    }

    public void Back()
    {
        TitleScreen.SetActive(true);
        BackButton.SetActive(false);
        InfoScreen.SetActive(false);
        SettingsScreen.SetActive(false);
        
    }

    public void Settings()
    {
        TitleScreen.SetActive(false);
        InfoScreen.SetActive(false);
        SettingsScreen.SetActive(true);

    }

    public void Play()
    {
        SceneManager.LoadScene("StartingArea");
    }

}
