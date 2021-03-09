using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rubbies : MonoBehaviour
{

    int PlayerScore;
    int currScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SFXScript.PlayAudio("gemcollect");
            currScore = ScoreScript.scoreValue += 100;
            PlayerScore = currScore;
            Destroy(gameObject);
        }
    }
}
