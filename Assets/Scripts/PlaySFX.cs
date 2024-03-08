using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    private GameObject pointPlayer;
    private AudioSource pointSound;
    private GameObject deathPlayer;
    private AudioSource deathSound;

    private void Start()
    {
        pointPlayer = GameObject.Find("PointSoundPlayer");
        pointSound = pointPlayer.GetComponent<AudioSource>();

        deathPlayer = GameObject.Find("DeathSoundPlayer");
        deathSound = deathPlayer.GetComponent<AudioSource>();
    }

    public void PlayPoint()
    {
        pointSound.Play();
    }

    public void PlayDeath()
    {
        deathSound.Play();
    }
}
