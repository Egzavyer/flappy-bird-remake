using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    void Start()
    {
        //Display the current score and highscore
        scoreText.text = "Score: " + GameManager.score.ToString();
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("score").ToString();
    }

    public void Restart()
    {
        //Reset the score and load the Game scene when the Restart button is clicked
        GameManager.score = 0;
        SceneManager.LoadScene(1);
    }
}
