using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    // Method called whne player dies
    public void TriggerGameOver()
    {
        gameOverUI.SetActive(true); // Show Game Over UI

        Time.timeScale = 0f; // Pause the game
    }

    // Called by restart button
    public void RestartGame()
    {
        // Restart game by reloading the scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
