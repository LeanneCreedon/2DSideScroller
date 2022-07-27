using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    bool gameHasBeenWon = false;

    public GameObject gameOverUI;

    public GameObject completeLevelUI;


    // Complete Level method here
    public void CompleteLevel ()
    {
        if(gameHasBeenWon == false)
        {
            SoundManager.PlaySound ("levelComplete");
            Time.timeScale = 0f;
            gameHasBeenWon = true;
            completeLevelUI.SetActive(true);
        }   
    }


    // Ends game when Player loses all health
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            SoundManager.PlaySound ("gameOver");
            Time.timeScale = 0f; 
            gameHasEnded = true;
            gameOverUI.SetActive(true);
        }
    }

    
}
