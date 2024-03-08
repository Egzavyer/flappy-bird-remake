using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject gameManager;
    GameManager gameManagerScript;
    private void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        gameManagerScript.GameOver();
    }
}
