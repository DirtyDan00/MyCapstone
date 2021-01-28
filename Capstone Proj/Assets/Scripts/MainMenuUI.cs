using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "scene1":
                SceneManager.LoadScene("GameMode1");
                break;
            case "scene2":
                SceneManager.LoadScene("GameMode2");
                break;
            case "scene3":
                SceneManager.LoadScene("GameMode3");
                break;
            case "Highscores":
                SceneManager.LoadScene("HighScores");
                break;
        }

    }
}
