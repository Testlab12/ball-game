using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{


    [SerializeField] private AudioSource jumpSoundEffect;

    public float jumpForce;
    public bool grounded;
    public Rigidbody2D playerBody;
    void Start()
    {
       playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)  
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
            if (jumpSoundEffect != null) jumpSoundEffect.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground")){
            grounded = true;
        }
    }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground")){
            grounded = false;
        }
    }
}
