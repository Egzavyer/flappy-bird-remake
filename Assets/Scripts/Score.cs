using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private GameObject canvas;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");
        scoreText = canvas.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.score += 1;
        scoreText.text = GameManager.score.ToString();
    }
}
