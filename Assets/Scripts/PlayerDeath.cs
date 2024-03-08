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
        gameManagerScript = gameManager.GetComponent<GameManager>();

        soundPlayer = GetComponent<PlaySFX>();

        playerMovementScript = GetComponent<PlayerMovement>();
        playerMovementScript.enabled = true;

        coll = GetComponent<BoxCollider2D>();
        coll.enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
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
