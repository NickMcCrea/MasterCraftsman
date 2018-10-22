using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileHider : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<TilemapRenderer>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
