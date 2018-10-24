using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteJiggler : MonoBehaviour {


    float correctionRate = 0.1f;
    ParticleSystem particles;

	// Use this for initialization
	void Start () {

        particles =  gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newScale = Vector3.Lerp(gameObject.transform.localScale, Vector3.one, correctionRate);
        gameObject.transform.localScale = newScale;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jiggle();
        }
	}

    public void Jiggle()
    {

        particles.Play();
        particles.Emit(6);

        gameObject.transform.localScale = new Vector3(0.95f, 0.95f, 1);
    }
}
