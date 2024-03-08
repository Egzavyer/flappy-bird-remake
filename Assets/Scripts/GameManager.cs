using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;

    public void GameOver()
    {
        //Update the highscore if the current score is greater
        if (score > PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("score", score);
            PlayerPrefs.Save();
        }

        //Load the GameOver scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

