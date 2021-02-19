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
            MoonShoes.ClearOnDeath();
            GameMaster.PlayerDeath();
            //SceneManager.LoadScene("Level1");
            collision.transform.position = spawnPoint.position;
            
        }
    }
}
