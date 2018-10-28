using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITest : MonoBehaviour {

    const string glyphs = "abcdefghijklmnopqrstuvwxyz 0123456789";
    DialogueBoxController dbc;
    // Use this for initialization
    void Start ()
    {


        dbc = GameObject.Find("DialogueBox").GetComponent<DialogueBoxController>();

        //GameObject.Find("DialogueBox").SetActive(false);

    
    }

    private void ActivateDialogueTest()
    {
        string[] testStrings = new string[10];

        for (int i = 0; i < testStrings.Length; i++)
        {
            string s = "";
            int charAmount = Random.Range(50, 100); //set those to the minimum and maximum length of your string
            for (int j = 0; j < charAmount; j++)
            {
                s += glyphs[Random.Range(0, glyphs.Length)];
            }
            testStrings[i] = s;
        }



        dbc.SetText(testStrings);
        dbc.OpenDialogue();
    }

    // Update is called once per frame
    void Update () {


        if (Input.GetKeyDown(KeyCode.Space))
            ActivateDialogueTest();

	}
}
