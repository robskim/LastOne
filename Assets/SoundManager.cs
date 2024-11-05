using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource backgroundSource;
    public AudioSource sfxSource;

    public AudioClip backgroundMusic;
    public AudioClip gunShotSound;
    public AudioClip zombieGrowlSound;
    public AudioClip playerHitSound;
    public AudioClip zombieHitSound;
    public AudioClip playerDeathSound;

    void Start()
    {
        PlayBackgroundMusic();
    }

    public void PlayBackgroundMusic ()
    {
        if (backgroundMusic != null)
        {
            backgroundSource.clip = backgroundMusic;
            backgroundSource.loop = true;
            backgroundSource.Play();
        }
    }

    public void PlayGunShotSound()
    {
        sfxSource.PlayOneShot(gunShotSound);
    }

    public void PlayZombieGrowlSound()
    {
        sfxSource.PlayOneShot(zombieGrowlSound);
    }

    public void PlayPlayerHitSound()
    {
        sfxSource.PlayOneShot(playerHitSound);
    }

    public void PlayZombieHitSound()
    {
        sfxSource.PlayOneShot(zombieHitSound);
    }

    public void PlayPlayerDeathSound()
    {
        sfxSource.PlayOneShot(playerDeathSound);
    }
}
