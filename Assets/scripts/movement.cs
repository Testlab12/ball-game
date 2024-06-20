using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public const string RIGHT = "right";
    public const string LEFT = "left";
    public float moveSpeed = 5.0f;
     public float maxRunSpeed = 5f;
    string buttonPressed;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            buttonPressed = RIGHT;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            buttonPressed = LEFT;
        }
        else
        {
            buttonPressed = null;
        }
    }
    void FixedUpdate()
    {
        
        if (buttonPressed == RIGHT)
        {
            rb2d.AddForce(new Vector2(-moveSpeed, 0), ForceMode2D.Force);
        }
        else if (buttonPressed == LEFT)
        {
            rb2d.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Force);
        }
        CapVelocity();
    }
        public void CapVelocity()
    {
        float cappedXVelocity = Mathf.Min(Mathf.Abs(rb2d.velocity.x), maxRunSpeed) * Mathf.Sign(rb2d.velocity.x);
        float cappedYVelocity = rb2d.velocity.y;

        rb2d.velocity = new Vector3(cappedXVelocity, cappedYVelocity);
    }


}


