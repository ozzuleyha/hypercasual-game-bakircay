using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneButtons : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single); 
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
