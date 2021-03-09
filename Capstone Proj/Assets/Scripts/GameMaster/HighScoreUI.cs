using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreUI : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "ScoreAttack":
                SceneManager.LoadScene("ScoreAttackScores");
                break;
            case "TimeAttack":
                SceneManager.LoadScene("TimeAttackScores");
                break;
            case "MainMenu":
                SceneManager.LoadScene("Menu");
                break;
        }

    }
}
