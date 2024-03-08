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
        canvas = GameObject.Find("Canvas");
        scoreText = canvas.GetComponentInChildren<TextMeshProUGUI>();

        soundPlayer = GetComponent<PlaySFX>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.score += 1;
        soundPlayer.PlayPoint();
        scoreText.text = GameManager.score.ToString();
    }
}
