using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public float moveSpeed = 1.5f; // Zombie movement speed
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        // Finding the player GameObject by its tag 
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Zombie moves toward player only if player exists
        if (player != null)

        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
