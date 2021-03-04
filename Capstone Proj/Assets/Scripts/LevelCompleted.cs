using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
    public GameObject UIText;
    PlayerMovement player;

    void Start()
    {
        UIText.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Level Won!");
            UIText.SetActive(true);
            //player.rb2d.velocity = new Vector2(0, player.rb2d.velocity.y);
            StartCoroutine(WaitForIt(3.0F));
            
        }
    }

    IEnumerator WaitForIt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(UIText);
        SceneManager.LoadScene("LevelSelector");
    }
}
