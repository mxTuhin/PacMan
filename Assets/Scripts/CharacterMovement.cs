using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharacterMovement : MonoBehaviour
{
    
    /*public float speed = 5f;

    public Rigidbody2D rb;
    public UiCharacterControl LeftButton; // Drag & drop the left button object

    public UiCharacterControl RightButton; // Drag & drop the left button object

    public UiCharacterControl UpButton; // Drag & drop the left button object
    public UiCharacterControl DownButton; // Drag & drop the left button object

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(speed * moveY, rb.velocity.y);
        GetComponent<Animator>().SetFloat("DirY", moveY);
        rb.velocity = new Vector2(speed * moveX, rb.velocity.x);
        GetComponent<Animator>().SetFloat("DirX", moveX);

        if (LeftButton.IsPressed)
        {
            rb.velocity = new Vector2(speed * -1.0f, rb.velocity.y);
            GetComponent<Animator>().SetFloat("DirX", -1.0f);
        }
        if (RightButton.IsPressed)
        {
            rb.velocity = new Vector2(speed * 1.0f, rb.velocity.y);
            GetComponent<Animator>().SetFloat("DirX", 1.0f);
        }





        // Animation Parameters


    }*/


    float dirX, dirY;

    [Range(1f, 20f)]
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    public UiCharacterControl LeftButton; // Drag & drop the left button object

    public UiCharacterControl RightButton; // Drag & drop the left button object

    public UiCharacterControl UpButton; // Drag & drop the left button object
    public UiCharacterControl DownButton; // Drag & drop the left button object

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        GetComponent<Animator>().SetFloat("DirX", moveX);
        GetComponent<Animator>().SetFloat("DirY", moveY);
        transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);

        if (LeftButton.IsPressed)
        {
            rb.velocity = new Vector2(moveSpeed * -1.0f, rb.velocity.y);
            GetComponent<Animator>().SetFloat("DirX", -1.0f);
        }
        else if (RightButton.IsPressed)
        {
            rb.velocity = new Vector2(moveSpeed * 1.0f, rb.velocity.y);
            GetComponent<Animator>().SetFloat("DirX", 1.0f);
        }
        else if (!RightButton.IsPressed)
        {
            rb.velocity = new Vector2(moveSpeed * 0.0f, rb.velocity.y);
        }
        else if (!LeftButton.IsPressed)
        {
            rb.velocity = new Vector2(moveSpeed * 0.0f, rb.velocity.y);
        }


        if (UpButton.IsPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed * 1.0f);
            GetComponent<Animator>().SetFloat("DirY", 1.0f);
        }
        else if (DownButton.IsPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed * -1.0f);
            GetComponent<Animator>().SetFloat("DirY", -1.0f);
        }

        else if (!UpButton.IsPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed * 0.0f);
        }
        
        else if (!DownButton.IsPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed * 0.0f);
        }



    }

}
