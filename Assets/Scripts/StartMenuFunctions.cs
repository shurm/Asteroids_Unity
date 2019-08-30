using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuFunctions : MonoBehaviour
{
    public void LoadNewGame()
    {
        SceneManager.LoadScene("GameplayScene");
    }

    public void DisplayHighScore()
    {
        Debug.Log("HighScore Scene not yet implemented");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
