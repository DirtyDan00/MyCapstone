using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    int PlayerLives;
    bool endOfLevel = false;
    bool playerGameOver = false;
    bool gamemode1 = false;
    bool gamemode2 = false;
    bool gamemode3 = false;

    int GameModeSelection;
    void Start()
    {
        PlayerLives = 3;
        endOfLevel = false;
        playerGameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (endOfLevel == true)
        {
            LevelCompleted();
        }
        else if (playerGameOver == true)
        {
            GameOver();
        }
    }

    public static void LevelCompleted()
    {
        
        Debug.Log("Level Won!");
        SceneManager.LoadScene("Menu");
    }

    public void PlayerDeath()
    {

    }

    public void GameOver()
    {
        if (PlayerLives == 0)
        {
            playerGameOver = true;
        }
    }

    public void GameModeCheck()
    {
        
        switch(GameModeSelection)
        {
            case 1:
                gamemode1 = true;
                break;
            case 2:
                gamemode2 = true;
                break;
            case 3:
                gamemode3 = true;
                break;
        }
    }
}
