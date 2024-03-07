using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.score += 1;
        scoreText.text = GameManager.score.ToString();
    }
}
