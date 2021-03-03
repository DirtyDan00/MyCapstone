using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolVertically : MonoBehaviour
{
    public float speed;
    public bool moveUp;

    private void Update()
    {
        if(moveUp)
        {
            transform.Translate(0, 1.5f * Time.deltaTime * speed, 0);
            //transform.localScale = new Vector2(0.5f, 0.5f);
        } else
        {
            transform.Translate(0, -1.5f * Time.deltaTime * speed, 0);
            //transform.localScale = new Vector2(-0.5f, 0.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("turn"))
        {
            if(moveUp)
            {
                moveUp = false;
            }
            else
            {
                moveUp = true;
            }
        }
    }
}
