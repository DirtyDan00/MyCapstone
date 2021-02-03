using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Level 1":
                SceneManager.LoadScene("Level1");
                break;
            case "Level 2":
                SceneManager.LoadScene("Level2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Level3");
                break;
            case "Menu":
                SceneManager.LoadScene("Menu");
                break;
        }

    }
}
