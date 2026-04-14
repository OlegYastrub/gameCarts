using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFromGame : MonoBehaviour
{
    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToHelp()
    {
        SceneManager.LoadScene("Rules");
    }

    public void GoPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
