using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float JumpY = 5;
    public bool isOnGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isOnGround == true)
        {
            Debug.Log("hit");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, JumpY), ForceMode2D.Impulse);
        }
        
    }
}
