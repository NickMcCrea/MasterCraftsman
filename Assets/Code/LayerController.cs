using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    ParticleSystemRenderer[] particleSystems;

    // Use this for initialization
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        particleSystems = GetComponentsInChildren<ParticleSystemRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (spriteRenderer != null)
            spriteRenderer.sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;

        foreach (ParticleSystemRenderer s in particleSystems)
        {
            s.sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;
        }

    }
}
