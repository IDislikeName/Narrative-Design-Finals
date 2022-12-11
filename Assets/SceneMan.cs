using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainEvent1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
