using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; // Where the bullet fires from
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Left mouse button
        {
            Shoot();
            FindObjectOfType<SoundManager>().PlayGunShotSound();
        }
    }

    void Shoot()
    {
        // Calculate the direction from firepoint to the mouse position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        Vector2 direction = ((Vector2)mousePosition - (Vector2)firePoint.position).normalized;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.transform.position = new Vector3(bullet.transform.position.x, bullet.transform.position.y, 0);

        // Set bullet velocity in normalized direction of the mouse
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletSpeed;
    }
}
