using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnRate = 2f; // Zombie spawn rate
    public float spawnRangeX = 8f; // Zombie spawn ranges
    public float spawnRangeY = 8f;

    private float nextSpawnTime;

    // Update is called once per frame
    void Update()
    {
        // Check if it is time to spawn a new zombie
        if (Time.time >= nextSpawnTime)
        {
            SpawnZombie();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnZombie()
    {
        // Random position spawning of new zombies
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));

        Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
    }
}
