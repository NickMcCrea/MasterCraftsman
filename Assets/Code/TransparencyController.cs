using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyController : MonoBehaviour {

    GameObject player;
    SpriteRenderer spriteRenderer;
    Color originalColor;
    Color fadedColor;
	// Use this for initialization
	void Start () {

        player = GameObject.Find("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
        fadedColor = originalColor;
        fadedColor.a = 0.8f;
    }

	
	// Update is called once per frame
	void Update () {
		

        

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        spriteRenderer.color = fadedColor;
    }
    private void OnTriggerEnter2d(Collider other)
    {
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      
        spriteRenderer.color = originalColor;   
    }


}
