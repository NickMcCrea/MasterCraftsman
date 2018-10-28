using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour {

    RawImage fadeImage;
    public float desiredTransparency = 1;
    public float fadeTime = 0.2f;

	// Use this for initialization
	void Start () {

        fadeImage = GameObject.Find("FadeImage").GetComponent<RawImage>();
        Color currentColor = fadeImage.color;
        currentColor.a = 1;
        fadeImage.color = currentColor;
    }
	
	// Update is called once per frame
	void Update () {
		




	}

    private void OnGUI()
    {
        Color currentColor = fadeImage.color;
        currentColor.a = Mathf.Lerp(currentColor.a, desiredTransparency, fadeTime);
        fadeImage.color = currentColor;
    }
}
