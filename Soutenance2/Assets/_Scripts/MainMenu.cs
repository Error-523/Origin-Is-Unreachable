using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //SceneManager.UnloadScene(0);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayMulti()
    {
        SceneManager.LoadScene("Multi");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
