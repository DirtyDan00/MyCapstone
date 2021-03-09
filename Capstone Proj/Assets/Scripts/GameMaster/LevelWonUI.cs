using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWonUI : MonoBehaviour
{
    public void ReturnScene()
    {
        switch (this.gameObject.name)
        {
            case "MainMenu":
                SceneManager.LoadScene("Menu");
                break;
        }
    }
}