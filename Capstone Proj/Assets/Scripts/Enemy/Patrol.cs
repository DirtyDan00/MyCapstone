using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public bool moveRight;

    private void Update()
    {
        if(moveRight)
        {
            transform.Translate(1.5f * Time.deltaTime * speed, 0,0);
            transform.localScale = new Vector2(0.5f, 0.5f);
        } else
        {
            transform.Translate(-1.5f * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-0.5f, 0.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("turn"))
        {
            if(moveRight)
            {
                moveRight = false;
            }
            else
            {
                moveRight = true;
            }
        }
    }
}
