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
                SceneManager.LoadScene("LevelSelector");
                break;
        }
    }
}
