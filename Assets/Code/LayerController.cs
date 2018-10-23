using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour {
    
    SpriteRenderer renderer;

	// Use this for initialization
	void Start () {

        renderer = GetComponent<SpriteRenderer>();
       
	}
	
	// Update is called once per frame
	void Update () {

        renderer.sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;

    }
}
