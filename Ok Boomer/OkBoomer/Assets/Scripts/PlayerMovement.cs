﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveHorizontal;

    private Rigidbody2D rb;
    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask IsGround;

    private int extraJumps;
    public AudioSource jumpSound;

    public bool hasAmmo;
    public bool isPunching;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, IsGround);

        moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (facingRight == false && moveHorizontal > 0)
        { Flip();  }
        else if(facingRight == true && moveHorizontal < 0)
        { Flip();  }
 
    }

    void Update()
    {
        if(isGrounded == true)
        {
            extraJumps = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            jumpSound.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetBool("isExtraJump", true);

        }

        //Jump Animation Bools
        if(rb.velocity.y == 0 || isGrounded)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", false);

        }
        if (rb.velocity.y > 1)
        {
            anim.SetBool("isJumping", true);
        }
        if (rb.velocity.y < -2)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", true);

        }

        //Gun Animation
        if(hasAmmo == true)
        {
            anim.SetBool("hasAmmo", true);
        }
        else
        {
            anim.SetBool("hasAmmo", false);

        }
        
    }

    void Flip() //flips direction and character model
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
