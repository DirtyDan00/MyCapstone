using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SFXScript.PlayAudio("death");
            if(GameMaster.playerLives <=1)
            {
                TimerScript.ClearTimer();
                GameMaster.GameOver();
            }
            else
            {
                
                GameMaster.PlayerDeath();
                TimerScript.ClearTimer();
                ScoreScript.ClearScore();
                collision.transform.position = spawnPoint.position;
            }
            
            
        }
    }

    

    //IEnumerator WaitForIt(float waitTime)
    //{
    //    yield return new WaitForSeconds(waitTime);
    //}
}
