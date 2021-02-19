using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonShoes : MonoBehaviour
{
    public float gravity;
    public float jumpHeightTimer;
    public float jumpSpeed;
    public float slowdown;
    public float forceToPushUp;
    public static bool hasMoonBoots = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            hasMoonBoots = true;
            GameObject player = collision.gameObject;
            PlayerMovement playerComp = player.GetComponent<PlayerMovement>();

            if(playerComp)
            {
                playerComp.jumpSpeed = jumpSpeed;
                playerComp.jumptimer += jumpHeightTimer;
                playerComp.airTime = playerComp.jumptimer;
                playerComp.moveSpeed -= slowdown;
                playerComp.rb2d.gravityScale += -3.5f;
                Destroy(gameObject);
            }
        }
    }

    public static void ClearOnDeath()
    {
        hasMoonBoots = false;
    }
}
