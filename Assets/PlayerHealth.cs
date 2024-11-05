using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3; // Initial health
    public GameOver gameOver;
    public TextMeshProUGUI healthText;

    void Start()
    {
        UpdateHealthDisplay();
    }

    // Method is triggered when player collides with another object
    void OnTriggerEnter2D(Collider2D other)
    { 
        // Check if the object is indeed a Zombie
        if (other.CompareTag("Zombie"))
        {
            FindObjectOfType<SoundManager>().PlayPlayerHitSound();
            health--;
            Debug.Log("Player Health: " + health);
            UpdateHealthDisplay();

            // Check player's health has reached 0
            if (health <= 0 )
            {
                FindObjectOfType<SoundManager>().PlayPlayerDeathSound();
                Debug.Log("Game Over!");
                gameOver.TriggerGameOver();
                Destroy(gameObject); // Destroy the player
            }    
        }
    }
    
    void UpdateHealthDisplay()
    {
        healthText.text = "HP: " + health;
    }
}
