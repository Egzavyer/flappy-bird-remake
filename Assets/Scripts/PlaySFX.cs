using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    private GameObject pointPlayer;
    private AudioSource pointSound;
    private GameObject deathPlayer;
    private AudioSource deathSound;

    private void Start()
    {
        //Get the AudioSource components from the PointSoundPlayer and DeathSoundPlayer objects
        pointPlayer = GameObject.Find("PointSoundPlayer");
        pointSound = pointPlayer.GetComponent<AudioSource>();

        deathPlayer = GameObject.Find("DeathSoundPlayer");
        deathSound = deathPlayer.GetComponent<AudioSource>();
    }

    public void PlayPoint()
    {
        //Play the point sound
        pointSound.Play();
    }

    public void PlayDeath()
    {
        //Play the death sound
        deathSound.Play();
    }
}
