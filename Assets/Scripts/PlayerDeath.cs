using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject gameManager;
    private GameManager gameManagerScript;

    public GameObject bottomPipe;
    private PlayerMovement playerMovementScript;
    private BoxCollider2D coll;

    private PlaySFX soundPlayer;
    private void Start()
    {
        //Get the GameManager script from the GameManager object
        gameManagerScript = gameManager.GetComponent<GameManager>();

        //Get the PlaySFX script from the Player object
        soundPlayer = GetComponent<PlaySFX>();

        //Get the PlayerMovement script and BoxCollider2D component from the Player object
        playerMovementScript = GetComponent<PlayerMovement>();
        playerMovementScript.enabled = true;
        coll = GetComponent<BoxCollider2D>();
        coll.enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //If the player collides with a pipe, disable movement, disable collisions, play the death sound and end the game after a delay
        playerMovementScript.enabled = false;
        coll.enabled = false;
        soundPlayer.PlayDeath();
        StartCoroutine(EndGameCoroutine());
    }

    IEnumerator EndGameCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        gameManagerScript.GameOver();
    }
}
