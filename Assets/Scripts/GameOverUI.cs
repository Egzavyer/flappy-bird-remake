using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    void Start()
    {
        scoreText.text = "Score: " + GameManager.score.ToString();
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("score").ToString();
    }

    public void Restart()
    {
        GameManager.score = 0;
        SceneManager.LoadScene(1);
    }
}
