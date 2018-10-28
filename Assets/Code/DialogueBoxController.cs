using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBoxController : MonoBehaviour {



    private Queue<string> linesToDisplay;
    Image panel;
    Text textBox;
   


    // Use this for initialization
    void Start () {

        panel = gameObject.GetComponent<Image>();
        textBox = gameObject.GetComponentInChildren<Text>();
        linesToDisplay = new Queue<string>();
      
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Return))
            NextLine();

	}


    public void SetText(string[] lines)
    {
        linesToDisplay.Clear();
        for (int i = lines.Length - 1; i >= 0; i--)
            linesToDisplay.Enqueue(lines[i]);

    }

    public void OpenDialogue()
    {
        gameObject.SetActive(true);
        NextLine();
    }

    private void NextLine()
    {
        if(linesToDisplay.Count == 0)
        {
            return;
        }
        
        textBox.text = linesToDisplay.Dequeue();
    }
}
