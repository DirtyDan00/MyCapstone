using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    Text currentLives;
    static int PlayerLives;
    static bool playerGameOver = false;
    bool gamemode1 = false;
    bool gamemode2 = false;
    bool gamemode3 = false;

    int GameModeSelection;
    void Start()
    {
        PlayerLives = 3;
        playerGameOver = false;
        currentLives = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        currentLives.text = "Lives" + PlayerLives;
        
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
        SceneManager.LoadScene("GameOverScene");
        //save score
        //save time

    }

    public void GameModeCheck()
    {

        switch (GameModeSelection)
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
