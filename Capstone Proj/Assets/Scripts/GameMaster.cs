using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    static int PlayerLives;
    bool endOfLevel = false;
    static bool playerGameOver = false;
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
        
    }

    public static void LevelCompleted()
    {
        
        Debug.Log("Level Won!");
        SceneManager.LoadScene("Menu");
    }

    public static void PlayerDeath()
    {
        PlayerLives--;
        if(PlayerLives == 0)
        {
            GameOver();
        }
    }

    public static void GameOver()
    {

        Debug.Log("Game Over!");
        SceneManager.LoadScene("Menu");
        //save score
        //save time

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
