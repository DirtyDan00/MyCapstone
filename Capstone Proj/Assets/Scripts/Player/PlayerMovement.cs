using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float moveSpeed;
    public float moveInput;
    public float JumpY;
    public float jumpSpeed;
    public bool isOnGround = false;
    public bool isJump = false;
    public bool ceilingHit = false;
    public float jumptimer;
    public float airTime;
    public float MaxfallSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb2d.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(moveInput * moveSpeed, rb2d.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.freezeRotation = true;
        Physics2D.gravity = new Vector2(0,-5);  
        Jump();
        if (Input.GetKey(KeyCode.Space) && isJump == true)
        {
            if (jumptimer > 0)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, JumpY), ForceMode2D.Impulse);
                rb2d.velocity = Vector3.up * jumpSpeed;
                jumptimer -= Time.deltaTime;
                
                
            }
            else
            {
                isJump = false;
            }
        }


        if (Input.GetKeyUp(KeyCode.Space) || isOnGround == true)
        {
            isJump = false;
        }
        

        if(moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        
    }



    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isOnGround == true)
        {
            SFXScript.PlayAudio("jumpsfx");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, JumpY), ForceMode2D.Impulse);
            isOnGround = false;
            isJump = true;
            jumptimer = airTime;
            
        }
        
    }

    
}
