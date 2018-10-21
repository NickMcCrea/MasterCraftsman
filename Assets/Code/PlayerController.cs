using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rgBody;
    private float movementSpeed = 100f;



    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();
        rgBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 movementForce = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementForce += Vector2.left * movementSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementForce += Vector2.right * movementSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementForce += Vector2.up * movementSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementForce += Vector2.down * movementSpeed;

        }

        rgBody.AddForce(movementForce);


        animator.SetFloat("HorizontalMovement", movementForce.x);
        if(movementForce.x == 0)
        {
            animator.SetFloat("VerticalMovement", movementForce.y);
        }
        else
        {
            animator.SetFloat("VerticalMovement", 0);
        }


    }


}
