using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour {

   
    public GameObject Destination;
    public GameObject Player;
    public GameObject Camera;
    // Use this for initialization
    void Start () {
		
      
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Player.transform.position = Destination.transform.position;

        Camera.GetComponent<Cinemachine.CinemachineVirtualCamera>().PreviousStateIsValid = false;

    }
}
