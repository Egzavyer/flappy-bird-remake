using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void Play()
    {
        //Load the Game scene when the Play button is clicked
        SceneManager.LoadScene(1);
    }
}
