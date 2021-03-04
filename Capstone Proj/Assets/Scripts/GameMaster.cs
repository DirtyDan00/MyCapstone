using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    Text currentLives;
    public static int playerLives;
    void Start()
    {
        playerLives = 3;
        //currentLives = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        //currentLives.text = "Lives" + playerLives;

    }
    public static void PlayerDeath()
    {
        playerLives--;
        if(playerLives == 0)
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

}
