using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlipper : MonoBehaviour
{

    private Rigidbody2D rb2d;

    public PlayerMovement playa;

    private bool flip;

    public bool hasFlipper = false;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hasFlipper = true;
            Destroy(gameObject);
        }
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Flipper();
        }
    }

    public void Flipper()
    {
        if (hasFlipper == true)
        {
            playa.rb2d.gravityScale *= -1;
            Rotation();
        }
    }

    private void Rotation()
    {
        if(flip == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        } else
        {
            transform.eulerAngles = Vector3.zero;
        }
        
        flip = !flip;
    }
}
