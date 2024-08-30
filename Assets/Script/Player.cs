using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
 // Movement
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool grounded = true;

    void Update ()
    {
        //Jumping 
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }

        moveVelocity = 0 ;

        if (Input.GetKey (KeyCode.A))
        {
            moveVelocity = -speed;
        }

        if (Input.GetKey (KeyCode.D))
        {
            moveVelocity = speed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
    }
    // check if grounded
    void OnTriggerEnter2D()
    {
        grounded = true;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}

