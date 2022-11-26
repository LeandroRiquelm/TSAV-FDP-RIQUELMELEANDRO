using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);

        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
