using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlowerScript : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Object has entered the trigger");
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Object is in trigger");
        gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.up * 20000 * Time.deltaTime);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Object has left the trigger");
    }
}
