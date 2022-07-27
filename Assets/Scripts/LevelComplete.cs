using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject completeLevelUI;
    
    public static bool GameIsWon = false;

    void OnTriggerEnter2D ()
    {
        gameManager.CompleteLevel();
    }
 
    // Playing the next level
    public void NextLevel ()
    {
        Time.timeScale = 1f; 
        completeLevelUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Loading Main game menu when Menu button clicked
    public void LoadMenu ()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Menu");
    }

}
