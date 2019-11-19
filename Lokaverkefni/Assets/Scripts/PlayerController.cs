using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MoveSpeed;
    public float JumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    private Rigidbody2D theRB;

    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask WhatIsGround;

    public bool IsGrounded;

    private Animator anim;



    void Start()
    {

        theRB = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }


    void Update()
    {

        IsGrounded = Physics2D.OverlapCircle(GroundCheckPoint.position, GroundCheckRadius, WhatIsGround);

        if (Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-MoveSpeed, theRB.velocity.y);

        }
        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(MoveSpeed, theRB.velocity.y);

        }
        else
        {

            theRB.velocity = new Vector2(0, theRB.velocity.y);

        }

        if (Input.GetKeyDown(jump) && IsGrounded)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, JumpForce);
        }

        if (theRB.velocity.x < 0)
        {

            transform.localScale = new Vector3(-1, 1, 1);

        }
        else if (theRB.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


        anim.SetFloat("Speed", Mathf.Abs(theRB.velocity.x));
        anim.SetBool("Grounded", IsGrounded);

    }
}