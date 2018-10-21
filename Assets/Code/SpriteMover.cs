using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {


    public LayerMask collisionLayer;        
    private BoxCollider2D boxCollider;      
    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;
    private float movementSpeed = 50f;

                                          
    void Start () {

        boxCollider = GetComponent<BoxCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(Vector2.left * movementSpeed);
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce( Vector2.right * movementSpeed);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddForce(Vector2.up * movementSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddForce(Vector2.down * movementSpeed);
        }

    }

    ////Move returns true if it is able to move and false if not. 
    ////Move takes parameters for x direction, y direction and a RaycastHit2D to check collision.
    //protected bool Move(int xDir, int yDir, out RaycastHit2D hit)
    //{
    //    //Store start position to move from, based on objects current transform position.
    //    Vector2 start = transform.position;

    //    // Calculate end position based on the direction parameters passed in when calling Move.
    //    Vector2 end = start + new Vector2(xDir, yDir);

    //    //Disable the boxCollider so that linecast doesn't hit this object's own collider.
    //    boxCollider.enabled = false;

    //    //Cast a line from start point to end point checking collision on blockingLayer.
    //    hit = Physics2D.Linecast(start, end, collisionLayer);

    //    //Re-enable boxCollider after linecast
    //    boxCollider.enabled = true;

    //    //Check if anything was hit
    //    if (hit.transform == null)
    //    {
    //        //If nothing was hit, start SmoothMovement co-routine passing in the Vector2 end as destination
    //        //StartCoroutine(SmoothMovement(end));

    //        //Return true to say that Move was successful
    //        return true;
    //    }

    //    //If something was hit, return false, Move was unsuccesful.
    //    return false;
    //}

   


    
}
