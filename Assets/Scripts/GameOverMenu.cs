using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static bool GameIsOver = false;

    public GameObject gameOverMenuUI;

    // reloading same level when retry is clicked
    public void Retry ()
    {
        Time.timeScale = 1f; 
        gameOverMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameIsOver = false;
    }

    // Loading Main game menu when Menu button clicked
    public void LoadMenu ()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Menu");
    }
    

}
