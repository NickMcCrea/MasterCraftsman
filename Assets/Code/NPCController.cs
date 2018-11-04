using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {


    Animator animator;
    Rigidbody2D rgBody;
    private float movementSpeed = 100f;
    SpriteRenderer renderer;


    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();
        rgBody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
