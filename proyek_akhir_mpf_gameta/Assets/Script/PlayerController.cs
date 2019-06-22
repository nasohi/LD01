using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public float moveX;     
    public int JumpSpeed= 15;
    public bool Grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("Button_Left"))
        {
            rb.velocity = Vector2.left * speed;
        } 

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = Vector2.left * speed;
        }

        if (CrossPlatformInputManager.GetButton("Button_Right"))
        {
            rb.velocity = Vector2.right * speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = Vector2.right * speed;
        }


        if (CrossPlatformInputManager.GetButtonDown("Button_Jump") && Grounded == true)
        {
            rb.velocity = Vector2.up * JumpSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * JumpSpeed;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }
    }
}
