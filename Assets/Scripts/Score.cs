using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private GameObject canvas;

    private PlaySFX soundPlayer;

    private void Start()
    {
        //Get the TextMeshProUGUI component from the Canvas object
        canvas = GameObject.Find("Canvas");
        scoreText = canvas.GetComponentInChildren<TextMeshProUGUI>();

        //Get the PlaySFX script from the Player object
        soundPlayer = GetComponent<PlaySFX>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //If the player collides with a point trigger, increase the score, play the point sound and update the score text
        GameManager.score += 1;
        soundPlayer.PlayPoint();
        scoreText.text = GameManager.score.ToString();
    }
}
