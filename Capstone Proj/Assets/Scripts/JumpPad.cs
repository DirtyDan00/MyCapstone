using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb2d.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, speed), ForceMode2D.Impulse);
        }
    }
}

