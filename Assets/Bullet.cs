using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 2f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(1);
            }
            FindObjectOfType<SoundManager>().PlayZombieHitSound();
            Debug.Log("Zombie hit!");  // Confirmation message for hitting a zombie
            Destroy(other.gameObject);  // Destroy the zombie
            Destroy(gameObject);        // Destroy the bullet
        }
    }
}
