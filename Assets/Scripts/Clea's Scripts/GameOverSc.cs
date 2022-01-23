using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverSc : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("APPLICATION QUIT.");
        // Load Title Screen
        SceneManager.LoadScene("TitleScene");
    }

    public void Retry()
    {
        Debug.Log("APPLICATION RETRY.");
        //Load last scene
    }
}
